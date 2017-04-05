Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports Newtonsoft.Json
Imports System
Imports System.Net
Imports System.IO
Imports System.Text



' Fonctions : - plus forcément à jour
' GetTable(table as String) As DataTable        ' ex : GetTable("demandeurs")
' GetTableWithId(table as String, NomPk As String, Id As Integer) As DataTable      ' ex : GetTableWithId("emplacements","empl_id",4)

' Function GetFormInhumation(id As Integer) As FormulaireInhumation
' Function GetFormNvConcession(id As Integer) As FormulaireNvConcession
' Function GetFormNvConBenefs(IdForm) As Beneficiaire()
' PutFormInhumation(LeForm As FormulaireInhumation) As Integer      ' ajoute un nouveau form en bdd (table forms inhum + éventuellement form nv con & fnvcon bénéficiaires
'                                                                     renvoie l'id inséré
' Function PutFormNvCon(LeForm As FormulaireNvConcession) As Integer
' 


Module Bdd

    'Public Const URL_API = "http://phpcimetiere/connecteur.php"
    Public Const ERR_OK = 0, ERR_MAUVAIS_LOGIN = 1, ERR_PAS_IDENT = 2, ERR_SESS_EXP = 3, ERR_NON_AUTOR = 4, ERR_INPUT = 5, ERR_CMD = 6, ERR_OUTPUT = 7
    Public Const USER_AUCUN = 0, USER_SERVICEPOP = 1, USER_FOSSOYEUR = 2
    '' Préfixes permettant d'identifier le type de réponse reçue
    'Public Const PREFIXE_ERREUR = "ER", PREFIXE_IDENTIFICATION = "ID"


    ' Ajoute une entité, renvoie le nouvel Id
    ' Attention, ajoute aussi les entités liées (normalement)
    Function Add(ent As IEntityInterface) As Integer
        Using ctx As New CimBddContext
            Dim leset = ctx.Set(ent.GetType)
            leset.Add(ent)
            ctx.SaveChanges()
            Return ent.Id
        End Using
    End Function

    ' Charge une entité d'après son Id.
    Function Load(Of T As IEntityInterface)(id As Integer) As T
        Using ctx As New CimBddContext
            Dim leset = ctx.Set(GetType(T))
            Return leset.Find(id)
        End Using
    End Function

    ' Ajout, ou update si l'Id est présent
    Function Save(ent As IEntityInterface) As Integer
        Using ctx As New CimBddContext
            Dim leset = ctx.Set(ent.GetType)  ' Of... ? bof
            leset.Attach(ent)
            If ent.Id = Nothing Then
                ctx.Entry(ent).State = Data.Entity.EntityState.Added
            Else
                ctx.Entry(ent).State = Data.Entity.EntityState.Modified
            End If
            ctx.SaveChanges()
            Return ent.Id
        End Using
    End Function

    'Function GetConcession2(id As Integer) As Concession
    '    Using ctx As New CimBddContext
    '        Return (From con As Concession In ctx.Concessions.Include("Concessionnaire").Include("MentionsBenefs.Beneficiaire").Include("Emplacement.Sejour.Defunt")
    '                Where con.Id = id) _
    '               .Single
    '    End Using
    'End Function


    ' charge jusqu'à l'emplacement mais pas ses séjours/défunts (il y aurait trop de séjours passés)
    ' ne charge pas (encore ?) les personnes de contact, à voir
    Function GetConcession(id As Integer) As Concession
        Using ctx As New CimBddContext
            'Return (From con As Concession In ctx.Concessions.Include("Concessionnaire").Include("MentionsBenefs.Beneficiaire").Include("Emplacement.Sejour.Defunt")
            Return (From con As Concession In ctx.Concessions.Include("Concessionnaire").Include("MentionsBenefs.Beneficiaire").Include("Emplacement")
                    Where con.Id = id) _
                   .Single
        End Using
    End Function

    Function GetOccupantsActuels(empl As Emplacement) As List(Of Defunt)
        Using ctx As New CimBddContext
            'rq = From sej In ctx.Sejours
            '     Where sej.Defunt.sejour



        End Using
    End Function



    ' les "GetListe" : récupère certaines infos pour affichage "abrégé" dans une liste

    Function GetListeDefunts() As List(Of Defunt.InfosPourListe) 'IEnumerable(Of Object)
        Using ctx As New CimBddContext
            Dim rq = From def In ctx.Defunts.Include("SejourActif.Emplacement")
                     Order By def.Id Descending  ' derniers ajoutés seront les plus visibles
                     Select New Defunt.InfosPourListe With {
                        .Id = def.Id,
                        .Nom = def.Nom & " " & def.Prenom,
                        .NumeroLh = def.NumeroLh,
                        .DateDeces = def.DateDeces,
                        .RefEmplacement = def.SejourActif.Emplacement.Reference
                     }
            Return rq.ToList
        End Using
    End Function

    ' si il y a plusieurs milliers de concession, ça risque d'être assez lourd... à tester
    Function GetListeConcessions(Optional AussiExpirees = False) As List(Of Concession.InfosPourListe)
        Using ctx As New CimBddContext
            Dim datemax As Date = If(Not AussiExpirees, Today, #01/01/1753#)
            ' include peut-être pas utile si il y a ToList ?
            Dim rq1 = (From con As Concession In ctx.Concessions.Include("Concessionnaire").Include("MentionsBenefs.Beneficiaire").Include("Emplacement.Sejour.Defunt")
                       Where con.DateFin >= datemax
                       Select New With {
                         .Id = con.Id,
                         .PrenomCsnr = con.Concessionnaire.Prenom,
                         .NomCsnr = con.Concessionnaire.Nom,
                         .Numero = con.Numero,
                         .RefEmpl = con.Emplacement.Reference,
                         .Benefs = (From b In con.MentionsBenefs Select New With {.Nom = b.Beneficiaire.Nom, .Prenom = b.Beneficiaire.Prenom}),
                         .Defunts = (From s In con.Emplacement.Sejours Where s.Defunt.SejourActif Is s Select New With {.Nom = s.Defunt.Nom, .Prenom = s.Defunt.Prenom})        ' Is à tester
                     }).ToList

            Dim rq2 = From e In rq1.ToList
                      Select New Concession.InfosPourListe With {
                         .Id = e.Id,
                         .NomCsnr = e.NomCsnr,
                         .Numero = e.Numero,
                         .RefEmpl = e.RefEmpl,
                         .NomsBenefs = String.Join(", ", From b In e.Benefs Select Acteur.StaticNomComplet(b.Prenom, b.Nom)),
                         .NomsDefunts = String.Join(", ", From d In e.Defunts Select Acteur.StaticNomComplet(d.Prenom, d.Nom))
            }

            Return rq2.ToList

        End Using
    End Function

    Function GetCondenseActeurs() As List(Of IEntity.Condense)
        Using ctx As New CimBddContext
            Dim rq = From dem In ctx.Acteurs
                     Order By dem.Nom
                     Select New IEntity.Condense With {'With {
                         .Id = dem.Id,
                         .Nom = dem.Nom & " " & dem.Prenom
                     }
            Return rq.ToList
        End Using
    End Function


    ' Get acteur avec filtre sur nom, prénom et adresse
    ' sert à remplir la liste abrégée de la popup de recherche
    Function ChercherActeurs(text As String) As List(Of IEntity.Condense) 'List(Of Acteur.Condense)
        Using ctx As New CimBddContext
            Dim rq = From act In ctx.Acteurs
                     Where act.Nom.Contains(text) Or act.Prenom.Contains(text) Or act.Adresse.Contains(text)
                     Select New IEntity.Condense With { ' New With {
                        .Id = act.Id,
                        .Nom = act.Nom & " " & act.Prenom
                     }
            Return rq.ToList
        End Using
    End Function


    ' cherche un acteur dont le nom et le prénom correspondent
    ' sert à éviter les entrées en double, mais pas utilisé actuellement
    ' ne tient pas compte de la casse ni des diacritiques (dans l'état actuel de la configation de la bdd)
    Function IdentifierActeur(nom As String, prenom As String) As Acteur
        Using ctx As New CimBddContext
            Return (From c In ctx.Acteurs
                    Where c.Nom = nom And c.Prenom = prenom).FirstOrDefault
            ' si ils sont déjà deux à avoir le même nom, tant pis pour eux
        End Using
    End Function



    ' Vieux trucs


    'inclut sejouractif, emplacement
    Function ChargerDefunt(id As Integer) As Defunt
        Using ctx As New CimBddContext
            Dim rq = From def In ctx.Defunts.Include("SejourActif.Emplacement") ' ?
                     Where def.Id = id
            Return rq.Single
        End Using
    End Function


    'Function IdentifierDemandeur(nom As String, prenom As String) As Demandeur
    '    Using ctx As New CimBddContext
    '        Return (From d In ctx.Demandeurs
    '                Where d.Nom = nom And d.Prenom = prenom).FirstOrDefault
    '    End Using
    'End Function


    ' Pour Connexion directe
    ' Renvoie une datatable avec des une colonne id (la primary key) et une colonne texte du genre "Albert Dugaerjeoijn"
    Function GetListedemandeursEx() As DataTable
        Dim cmd As New MySqlCommand With {.Connection = Connexion()}
        cmd.CommandText = "Select dmdr_id As id, CONCAT(dmdr_prenom, "" "", dmdr_nom) As texte FROM demandeurs"
        Dim Adapter As New MySqlDataAdapter
        Dim dsResultats As New DataSet
        Adapter.SelectCommand = cmd
        Adapter.Fill(dsResultats)

        Return dsResultats.Tables(0)

    End Function


    ' Renvoie une datatable avec des une colonne id (la primary key) et une colonne texte du genre "Albert Dugaerjeoijn"
    ' Utilise connexion directe
    'Function RechercherCorrespondanceDemandeursEx(texte As String) As DataTable
    '    Dim cmd = New MySqlCommand
    '    cmd.CommandText = "Select dmdr_id As id, CONCAT(dmdr_prenom, "" "", dmdr_nom) AS texte FROM demandeurs " _
    '        & "WHERE dmdr_nom Like @txt Or dmdr_prenom Like @txt Or dmdr_adresse Like @txt"
    '    cmd.Connection = Connexion()
    '    cmd.Parameters.AddWithValue("txt", "%" & texte & "%")
    '    ' .CommandType = CommandType.Text ??
    '    Dim Adapter As New MySqlDataAdapter
    '    Dim dsResultats As New DataSet
    '    Adapter.SelectCommand = cmd
    '    Adapter.Fill(dsResultats)
    '    'Connexion.Close()
    '    Return dsResultats.Tables(0)
    'End Function


    ' TESTS avec EF

    ' pas fini
    ' met à jour une entité en fonction de son id (et de son type) // requête sur un set générique récupéré de façon détournée
    '(http//stackoverflow.com/questions/19609981/dbset-casttentity-error-cannot-create-a-dbsetientity-from-a-non-generic-d)
    '(http://stackoverflow.com/a/19697145)
    'update aussi les entités liées ? 
    Sub Update(Of T As IEntityInterface)(id As Integer, nouvent As T)
        Using ctx As New CimBddContext
            Dim lent As T
            Dim setMethod = GetType(CimBddContext).GetMethod("Set", System.Type.EmptyTypes).MakeGenericMethod(GetType(T))
            Dim leset = CType(setMethod.Invoke(ctx, {}), IQueryable(Of T))

            Dim req =
                From poiu As T In leset
                Where poiu.Id = id
            lent = req.SingleOrDefault
            lent = CType(req.SingleOrDefault, T)

            'Dim entr = ctx.Entry(lent)
            'entr.OriginalValues.SetValues(lent)
            'entr.CurrentValues.SetValues(nouvent)

            ctx.SaveChanges()

            'essayer simplement leset = ctx.Set(Of T) ?
        End Using
    End Sub


    ' récupère un item d'après son id ; en principe, ne fait pas de nouvelle requête bdd si déjà chargé
    Sub recupereid()
        Dim ctx As New CimBddContext
        Dim mort1 = ctx.Defunts.Find(1)
        mort1 = ctx.Defunts.Find(1)
    End Sub





    ' leform.Beneficiaires(0) = Nothing     ' incorrect : "Expression Is a value And therefore cannot be the target of an assignment

    'désassociation en mettant le membre (une liste) à Nothing (le/les items liés se sont pas supprimés)
    Sub desassoclistenothing()
        Dim ctx As New CimBddContext
        Dim req = From item In ctx.FormulairesInhumation        ' ou ctx.FormulairesInhumation.Find(id)
                  Where item.Id = 13
        Dim leforminh = req.First
        leforminh.FormNvCon = Nothing
        ctx.SaveChanges()
    End Sub


    'création d'un nouvel item ; l'id spécifié est ignoré (qu'il existe ou non, l'autoincrement décidera)
    Sub creerlidosef()
        Dim ctx As New CimBddContext
        unform = New FormulaireNvConcession With {.Id = 30, .PmandNom = "Tombal", .PmandPrenom = "Pierre"}
        ctx.FormulairesNvConcession.Add(unform)
        ctx.SaveChanges()
    End Sub



    ' retire association (du moins tente) en retirant un item de la liste de membres liés (dans une relation 1-n)
    Sub defairerelation()
        Dim ctx As New CimBddContext
        Dim req1 = From item In ctx.FormulairesNvConcession
                   Where item.Id = 16
        Dim leform = req1.First
        leform.Beneficiaires.Remove(leform.Beneficiaires(0))
        ctx.SaveChanges()                                       ' erreur : la fk ne peut être mise à NULL (donc le bénéficiaire est juste dé-lié, pas supprimé)
    End Sub


    ' changement d'association par changement de membre de navigation
    Sub changeassociationparmembre()
        Dim ctx As New CimBddContext
        Dim req1 = From item In ctx.FormulairesNvConcession
                   Where item.Id = 16
        Dim leform1 = req1.First

        Dim req2 = From item In ctx.FormulairesNvConcession
                   Where item.Id = 17
        Dim leform2 = req2.First
        leform2.Beneficiaires.Add(leform1.Beneficiaires(0))   ' transfert d'un bénéficiaire du form1 au form2 - le bénef est lié à l'objet leform2, mais est toujours lié au form1

        ctx.SaveChanges()           ' le bénéf a bien été retiré de form1, sa fk a été changée   ' ctx.SaveChanges() inclut ctx.ChangeTracker.DetectChanges()
    End Sub


    ' changement d'association par changement de la fk (de l'item associé)
    Sub changeassociationparfk()
        Dim ctx As New CimBddContext
        Dim req = From item In ctx.FormulairesNvConcession
                  Where item.Id = 17
        Dim leform = req.First
        MessageBox.Show(leform.Beneficiaires(0).Id & " " & leform.Beneficiaires(0).Nom)

        leform.Beneficiaires(0).FkFnvcon = 16                                                  ' un bénéf du form 17 prend la fk du form 16

        MessageBox.Show(leform.Beneficiaires(0).Id & " " & leform.Beneficiaires(0).Nom)        ' le bénéf est toujours accessible parmi les bénéficiaires du form 17

        Dim req2 = From item In ctx.FormulairesNvConcession                                    ' il n'est pas chargé avec le form 16
                   Where item.Id = 16 ''
        Dim lautreform = req2.First

        ctx.ChangeTracker.DetectChanges()

        MessageBox.Show(leform.Beneficiaires(0).Id & " " & leform.Beneficiaires(0).Nom)        ' maintenant il est correctement lié au 16


    End Sub

    ' changement d'association par changement de la fk
    Sub assocentit()
        Dim ctx As New CimBddContext
        Dim req = From item In ctx.FnvConBenefs
                  Where item.Id = 5
        Dim leben = req.First
        MessageBox.Show(leben.FormNvCon.Id & " " & leben.FormNvCon.PmandNom)       ' leben.FormNvCon est le form 16

        leben.FkFnvcon = 17
        MessageBox.Show(leben.FormNvCon.Id & " " & leben.FormNvCon.PmandNom)        ' leben.FormNvCon est toujours le form 16

        ctx.SaveChanges()

        MessageBox.Show(leben.FormNvCon.Id & " " & leben.FormNvCon.PmandNom)        ' Maintenant, c'est le form 17

    End Sub


    ' Accès à une même entité via des objets différents
    Sub des_manips()
        Dim ctx As New CimBddContext

        Dim reqform = From item In ctx.FormulairesNvConcession
                      Where item.Id = 16
        Dim leform = reqform.First
        leform.Beneficiaires(0).Nom = "Krobelaar"

        Dim reqben = From item In ctx.FnvConBenefs
                     Where item.Id = 5         ' bénéficiaire lié au form ci-dessus
        Dim lebenef = reqben.First          ' tient compte du changement fait en tant que leform.Beneficiaires(0)

        lebenef.Nom = "Nijuhyge"            ' idem, le changement concerne aussi leform.Beneficiaires(0)

        MessageBox.Show(leform.Beneficiaires(0).Nom)



    End Sub

    Sub contextedispose()
        Dim ctx As New CimBddContext
        Dim req = From item In ctx.FormulairesNvConcession
                  Where item.Id = 16
        Dim leform = req.First
        ctx.Dispose()
        ctx = Nothing

        ctx = New CimBddContext
        leform.PmandNom = "Fourne"
        leform.Beneficiaires(0).Nom = "Kröll"                   ' "The ObjectContext instance has been disposed And cann no longer be used for operations that require a connection"
        ctx.SaveChanges()                                       ' (leform "pointe" toujours vers l'ancien contexte, qui n'existe plus, d'où l'erreur)
    End Sub

    ' modification d'un item existant et d'un item lié, même objet contexte
    Sub modiformnouv()
        Dim ctx As New CimBddContext
        Dim req = From item In ctx.FormulairesNvConcession
                  Where item.Id = 16
        Dim leform = req.First
        leform.PmandNom = "Fourne"
        leform.Beneficiaires(0).Nom = "Kusp"
        ctx.SaveChanges()
    End Sub

    ' enregistrement simple d'un nouvel élément
    Sub ajout_nouveau_form_nvcon()
        Dim leformnvc = New FormulaireNvConcession With {.CsnrNom = "Dupzceuezds", .CsnrPrenom = "Rcidsjfène"}
        ' leformnvc.Beneficiaires = {New FnvConBenef With {.Nom = "Grozejez", .Prenom = "Gruwciueh"}, New FnvConBenef With {.Nom = "Tazeods", .Prenom = "Pecozsx"}}
        Dim contexte As New CimBddContext
        contexte.FormulairesNvConcession.Add(leformnvc)
        contexte.SaveChanges()
    End Sub


    'chargement lazy des entités associées
    Sub choper_form_nvc()
        Dim contexte As New CimBddContext
        Dim req = From item In contexte.FormulairesNvConcession
                  Select item
        Dim listeform = req.ToList      ' la requête bdd se fait ici
        Dim osef As Integer
        osef = 5
        Dim lebenef = listeform(0).Beneficiaires(0)     ' et ici (lazy loading)
    End Sub

    ' récupère plusieurs items sous forme d'une liste
    Sub choper_truc()
        Dim Contexte As New CimBddContext
        Dim Req = From item In Contexte.Emplacements
                  Select item
        Dim uze = Req.ToList()
    End Sub

    ' récupère un (le premier) item
    Sub choper_un_emplacement()
        Dim contexte As New CimBddContext
        Dim req = From item In contexte.Emplacements
                  Where item.Id = 1
                  Select item
        Dim resu As Emplacement = req.First()
    End Sub

    Function GetEmplacements(Optional parcelle As String = "") As List(Of Emplacement)
        Using ctxt As New CimBddContext
            Dim req = From item In ctxt.Emplacements
                      Select item
            Return req.ToList()
        End Using
    End Function


    ' Pour connexion directe au serveur sql
    Private Function Connexion() As MySqlConnection
        conn = New MySqlConnection
        conn.ConnectionString = "Server=" & ConfigLocale.BddHost & ";Database=" & ConfigLocale.BddNom & ";Uid=" & ConfigLocale.BddUser & ";Pwd=" & ConfigLocale.BddPass & ";"
        conn.Open()
        Return conn
    End Function

    ' Pour connexion via interface (PHP)
    ' À faire
    ' Identifie l'utilisateur pour login. Renvoie une constant USER_* et éventuellement un message d'erreur 
    Public Function Identification(Nom As String, Mdp As String, Optional ByRef RetourMsgErreur As String = "") As Integer

        '''' (très) temporaire
        'Return USER_SERVICEPOP
        'Dim aze As String = "ze"
        'Dim rty As String
        'rty = aze.Substring(2)
        'MessageBox.Show(rty)
        'Return 2

        Dim erreur As BddErreur
        Dim InfosLogin As BddDataIdentifiants = New BddDataIdentifiants(Nom, Mdp)
        Dim ResultatLogin As BddReponseIdentification = ExecuterCommandeBdd("identification", InfosLogin, erreur)
        RetourMsgErreur = erreur.message
        If erreur.code = ERR_OK Then
            Return ResultatLogin.UserType
        Else
            'Return Nothing
            Return USER_AUCUN
        End If
    End Function


    ' Ancienne version (mysql)
    '*** Récupère une table
    Function GetTable(table As String) As DataTable

        Dim cmd As New MySqlCommand With {.Connection = Connexion()}
        cmd.CommandText = "SELECT * FROM " & table
        Dim Adapter As New MySqlDataAdapter
        Dim dsResultats As New DataSet
        Adapter.SelectCommand = cmd
        Adapter.Fill(dsResultats)

        'cmd = Nothing   ' ?

        Return dsResultats.Tables(0)

    End Function


    Function GetTableWithId(table As String, NomPk As String, Id As Integer) As DataTable

        Dim cmd As New MySqlCommand With {.Connection = Connexion()}
        cmd.CommandText = "SELECT * FROM forms_inhumation WHERE " & NomPk & " = @id"
        cmd.Parameters.AddWithValue("id", Id)
        Dim Adapter As New MySqlDataAdapter
        Dim dsResultats As New DataSet
        Adapter.SelectCommand = cmd
        Adapter.Fill(dsResultats)

        'cmd = Nothing   ' ?

        Return dsResultats.Tables(0)

    End Function


    ' Obsolète
    ' insère un nouveau formulaire de demande d'inhumation
    ' renvoie l'id inséré
    ' fonction faite à l'arrache pour pouvoir continuer le reste
    Public Function PutFormInhumation_anc(LeForm As FormulaireInhumation) As Integer
        ' si il y a un form nouvelle concession associé, le crée aussi
        If LeForm.FormNvCon IsNot Nothing Then
            Dim idformnvcon As Integer
            idformnvcon = PutFormNvCon(LeForm.FormNvCon)
        End If

        Dim cmd = New MySqlCommand
        cmd = New MySqlCommand
        cmd.CommandText = "INSERT INTO forms_inhumation (fdec_num_def_lh,fdec_num_def_annee,fdec_def_nom,fdec_def_prenom,fdec_def_adresse,fdec_def_cp,fdec_def_ville,fdec_def_pays,fdec_def_etat_civil,fdec_def_etat_civil_de,fdec_def_date_naiss,fdec_def_lieu_naiss,fdec_def_date_deces,fdec_def_lieu_deces,fdec_dmdr_nom,fdec_dmdr_prenom,fdec_dmdr_tel,fdec_dmdr_adresse,fdec_dmdr_ville,fdec_dmdr_cp,fdec_dmdr_pays,fdec_conc_sollic,fdec_ref_empl,fdec_ref_autres_def,fdec_date_sign,fdec_avis_fossoy,fdec_commentaire,fdec_fk_def,fdec_fk_dmdr,fdec_fk_fnvcon)" _
                           & " VALUES (@nudlh,@nudan,@nd,@pd,@add,@cpd,@vd,@payd,@etad,@etadd,@dnd,@lnd,@ddd,@ldd,@dmn,@dmp,@dmt,@dmad,@dmv,@dmcp,@dmpay,@consol,@refe,@refad,@dat,@af,@com,@fkdef,@fkdmdr,@fknvcon)" _
                           & " ; SELECT LAST_INSERT_ID()"
        cmd.Connection = Connexion()
        With LeForm
            cmd.Parameters.AddWithValue("nudlh", .NumDefLh)
            cmd.Parameters.AddWithValue("nudan", .NumDefAnnee)
            cmd.Parameters.AddWithValue("nd", .DefNom)
            cmd.Parameters.AddWithValue("pd", .DefPrenom)
            cmd.Parameters.AddWithValue("add", .DefAdresse)
            cmd.Parameters.AddWithValue("cpd", .DefCp)
            cmd.Parameters.AddWithValue("vd", .DefVille)
            cmd.Parameters.AddWithValue("payd", .DefPays)
            cmd.Parameters.AddWithValue("etad", .DefEtatCivil)
            cmd.Parameters.AddWithValue("etadd", .DefEtatCivilDe)
            cmd.Parameters.AddWithValue("dnd", .DefDateNaiss)
            cmd.Parameters.AddWithValue("lnd", .DefLieuNaiss)
            cmd.Parameters.AddWithValue("ddd", .DefDateDeces)
            cmd.Parameters.AddWithValue("ldd", .DefLieuDeces)
            cmd.Parameters.AddWithValue("dmn", .DmdrNom)
            cmd.Parameters.AddWithValue("dmp", .DmdrPrenom)
            cmd.Parameters.AddWithValue("dmt", .DmdrTel)
            cmd.Parameters.AddWithValue("dmad", .DmdrAdresse)
            cmd.Parameters.AddWithValue("dmv", .DmdrVille)
            cmd.Parameters.AddWithValue("dmcp", .DmdrCp)
            cmd.Parameters.AddWithValue("dmpay", .DmdrPays)
            cmd.Parameters.AddWithValue("consol", .ConcSollic)
            cmd.Parameters.AddWithValue("refe", .RefEmpl)
            cmd.Parameters.AddWithValue("refad", .RefAutresDef)
            cmd.Parameters.AddWithValue("dat", .DateSign)
            cmd.Parameters.AddWithValue("af", .AvisFossoy)
            cmd.Parameters.AddWithValue("com", .Commentaire)
            '            cmd.Parameters.AddWithValue("fkdmdr", .FkDmdr)
        End With
        Return Convert.ToInt32(cmd.ExecuteNonQuery())

        'si le form nvcon a des bénéficiaires, les ajouter aussi
        '        sqlCommand.Connection = conn
        '        sqlCommand.CommandText = str_carSql
        '        sqlCommand.ExecuteNonQuery()
        'Connexion.Close()
    End Function


    ' obsolète
    ' enregistre un nouveau formulaire de demande de concession
    Function PutFormNvCon(LeForm As FormulaireNvConcession) As Integer
        Dim cmd = New MySqlCommand
        cmd.CommandText = "INSERT INTO forms_nouvelle_con" _
                & " (fnvcon_pmand_nom,fnvcon_pmand_prenom,fnvcon_pmand_date_naiss,fnvcon_pmand_tel,fnvcon_pmand_adresse," _
                & "fnvcon_pmand_ville,fnvcon_pmand_cp,fnvcon_pmand_pays,fnvcon_csnr_nom,fnvcon_csnr_prenom,fnvcon_csnr_date_naiss,fnvcon_csnr_no_national," _
                & "fnvcon_csnr_adresse,fnvcon_csnr_ville,fnvcon_csnr_cp,fnvcon_csnr_pays,fnvcon_csnr_tel,fnvcon_date_sign," _
                & "fnvcon_demandeur_est,fnvcon_commentaire,fnvcon_fk_con) VALUES" _
                & " (@pmn,@pmp,@pmdn,@pmt,@pma,@pmv,@pmcp,@pmpay,@csn,@csp,@csdn,@csnn,@csa,@csv,@cscp,@cspay,@cstel,@dat,@dest,@com,@fkc)" _
                & " ; SELECT LAST_INSERT_ID()"

        cmd.Connection = Connexion()
        With LeForm
            cmd.Parameters.AddWithValue("pmn", .PmandNom)
            cmd.Parameters.AddWithValue("pmp", .PmandPrenom)
            cmd.Parameters.AddWithValue("pmdn", .PmandDateNaiss)
            cmd.Parameters.AddWithValue("pmt", .PmandTel)
            cmd.Parameters.AddWithValue("pma", .PmandAdresse)
            cmd.Parameters.AddWithValue("pmv", .PmandVille)
            cmd.Parameters.AddWithValue("pmcp", .PmandCp)
            cmd.Parameters.AddWithValue("pmpay", .PmandPays)
            cmd.Parameters.AddWithValue("csn", .CsnrNom)
            cmd.Parameters.AddWithValue("csp", .CsnrPrenom)
            cmd.Parameters.AddWithValue("csdn", .CsnrDateNaiss)
            cmd.Parameters.AddWithValue("csnn", .CsnrNoNational)
            cmd.Parameters.AddWithValue("csa", .CsnrAdresse)
            cmd.Parameters.AddWithValue("csv", .CsnrVille)
            cmd.Parameters.AddWithValue("cscp", .CsnrCp)
            cmd.Parameters.AddWithValue("cspay", .CsnrPays)
            cmd.Parameters.AddWithValue("cstel", .CsnrTel)
            cmd.Parameters.AddWithValue("dat", .DateSign)
            cmd.Parameters.AddWithValue("dest", .SigneParPmand)
            cmd.Parameters.AddWithValue("com", .Commentaire)
            'cmd.Parameters.AddWithValue("fkc", .FkCon)
        End With
        Dim idformnvcon As Integer = Convert.ToInt32(cmd.ExecuteScalar())

        For Each benef As FnvConBenef In LeForm.Beneficiaires
            cmd = New MySqlCommand
            cmd.Connection = Connexion()
            cmd.CommandText = "INSERT INTO form_nouvelle_con_beneficiaires" _
                    & " (fnvconben_nom,fnvconben_prenom,fnvconben_date_naiss,fnvconben_lien_parente,fnvconben_adresse,fnvconben_ville,fnvconben_cp,fnvconben_pays,fnvconben_fk_fnvcon)" _
                    & " VALUES" _
                    & "(@bn,@bp,@bdn,@blp,@badr,@bv,@bcp,@bpay,@bfkd)"
            With benef
                cmd.Parameters.AddWithValue("bfkd", idformnvcon)
                cmd.Parameters.AddWithValue("bpay", .Pays)
                cmd.Parameters.AddWithValue("bcp", .Cp)
                cmd.Parameters.AddWithValue("bv", .Ville)
                cmd.Parameters.AddWithValue("badr", .Adresse)
                cmd.Parameters.AddWithValue("blp", .LienParente)
                cmd.Parameters.AddWithValue("bdn", .DateNaiss)
                cmd.Parameters.AddWithValue("bn", .Nom)
                cmd.Parameters.AddWithValue("bp", .Prenom)
            End With
            cmd.ExecuteNonQuery()
        Next
        Return idformnvcon
    End Function


    ' Obsolète
    ' Renvoie une datatable, pas (encore ?) un objet FormulaireInhumation
    ' À continuer : doit aussi lire la partie nouvelle concession avec les bénéficiaires
    Function GetFormInhumation(id As Integer) As FormulaireInhumation
        Dim dtResultat As DataTable = GetTableWithId("forms_inhumation", "fdec_id", id)
        Dim ligne As DataRow = dtResultat.Rows(0)
        Dim LeForm As New FormulaireInhumation
        ' automatiser ?
        With LeForm
            .Id = ligne("fdec_id")
            .NumDefLh = ligne("fdec_num_def_lh")
            .NumDefAnnee = ligne("fdec_num_def_annee")
            .DefNom = ligne("fdec_def_nom")
            .DefPrenom = ligne("fdec_def_prenom")
            .DefAdresse = ligne("fdec_def_adresse")
            .DefCp = ligne("fdec_def_cp")
            .DefVille = ligne("fdec_def_ville")
            .DefPays = ligne("fdec_def_pays")
            .DefEtatCivil = ligne("fdec_def_etat_civil")
            .DefEtatCivilDe = ligne("fdec_def_etat_civil_de")
            .DefDateNaiss = ligne("fdec_def_date_naiss")
            .DefDateDeces = ligne("fdec_def_date_deces")
            .DefLieuNaiss = ligne("fdec_def_lieu_naiss")
            .DefLieuDeces = ligne("fdec_def_lieu_deces")
            .DmdrNom = ligne("fdec_dmdr_nom")
            .DmdrPrenom = ligne("fdec_dmdr_prenom")
            .DmdrTel = ligne("fdec_dmdr_tel")
            .DmdrAdresse = ligne("fdec_dmdr_adresse")
            .DmdrVille = ligne("fdec_dmdr_ville")
            .DmdrCp = ligne("fdec_dmdr_cp")
            .DmdrPays = ligne("fdec_dmdr_pays")
            .ConcSollic = ligne("fdec_conc_sollic")
            .RefEmpl = ligne("fdec_ref_empl")
            .RefAutresDef = ligne("fdec_ref_autres_def")
            .DateSign = ligne("fdec_date_sign")
            .AvisFossoy = ligne("fdec_avis_fossoy")
            .Commentaire = ligne("fdec_commentaire")
            '.FkDmdr = If(Not IsDBNull(ligne("fdec_fk_dmdr")), ligne("fdec_fk_dmdr"), Nothing)
        End With
        Return LeForm
    End Function


    '' Renvoie un objet FormulaireNvConcession
    'Function GetFormNvConcession(id As Integer) As FormulaireNvConcession
    '    Dim dtResultat As DataTable = GetTableWithId("forms_nouvelle_con", "fnvcon_id", id)
    '    Dim ligne As DataRow = dtResultat.Rows(0)
    '    Dim LeForm As New FormulaireNvConcession
    '    'moyen d'automatiser ?
    '    With LeForm
    '        .Id = ligne("fnvcon_id")
    '        .PmandNom = ligne("fnvcon_pmand_nom")
    '        .PmandPrenom = ligne("fnvcon_pmand_prenom")
    '        .PmandDateNaiss = ligne("fnvcon_pmand_date_naiss")
    '        .PmandTel = ligne("fnvcon_pmand_tel")
    '        .PmandAdresse = ligne("fnvcon_pmand_adresse")
    '        .PmandVille = ligne("fnvcon_pmand_ville")
    '        .PmandPays = ligne("fnvcon_pmand_pays")
    '        .PmandCp = ligne("fnvcon_pmand_cp")
    '        .CsnrNom = ligne("fnvcon_csnr_nom")
    '        .CsnrPrenom = ligne("fnvcon_csnr_prenom")
    '        .CsnrDateNaiss = ligne("fnvcon_csnr_date_naiss")
    '        .CsnrNoNational = ligne("fnvcon_csnr_no_national")
    '        .CsnrAdresse = ligne("fnvcon_csnr_adresse")
    '        .CsnrVille = ligne("fnvcon_csnr_ville")
    '        .CsnrPays = ligne("fnvcon_csnr_pays")
    '        .CsnrCp = ligne("fnvcon_csnr_cp")
    '        .CsnrTel = ligne("fnvcon_csnr_tel")
    '        .DateSign = ligne("fnvcon_date_sign")
    '        .SigneParPmand = ligne("fnvcon_demandeur_est")
    '        .Commentaire = ligne("fnvcon_commentaire")
    '        '.FkCon = If(Not IsDBNull(ligne("fnvcon_fk_con")), ligne("fnvcon_fk_con"), Nothing)
    '        .Beneficiaires = GetFormNvConBenefs(.Id)
    '    End With
    '    Return LeForm
    'End Function


    '' récupère les bénéficiaires notés sur un form demande de concession (pas ceux de la table "bénéficiaires")
    'Function GetFormNvConBenefs(IdForm) As Beneficiaire()
    '    Dim cmd As New MySqlCommand With {.Connection = Connexion()}
    '    cmd.CommandText = "Select * FROM forms_nouvelle_con_beneficiaires WHERE fnvconben_fk_fnvcon = @idform"
    '    cmd.Parameters.AddWithValue("idform", IdForm)
    '    Dim Adapter As New MySqlDataAdapter
    '    Dim dsResultats As New DataSet
    '    Adapter.SelectCommand = cmd
    '    Adapter.Fill(dsResultats)

    '    Dim i As Integer = dsResultats.Tables(0).Rows.Count
    '    Dim benefs(i) As Beneficiaire
    '    For i = 0 To i
    '        beneflu = dsResultats.Tables(0).Rows(i)
    '        benefs(i) = New Beneficiaire
    '        With benefs(i)
    '            .Id = beneflu("fnvconben_id")
    '            .Nom = beneflu("fnvconben_nom")
    '            .Prenom = beneflu("fnvconben_prenom")
    '            .DateNaiss = beneflu("fnvconben_date_naiss")
    '            .LienParente = beneflu("fnvconben_lien_parente")
    '            .Adresse = beneflu("fnvconben_adresse")
    '            .Ville = beneflu("fnvconben_ville")
    '            .Cp = beneflu("fnvconben_cp")
    '            .Pays = beneflu("fnvconben_pays")
    '        End With
    '    Next

    '    'cmd = Nothing   ' ?

    '    Return benefs

    'End Function



    ' récupère toutes (?) les données d'un demandeur d'après son id
    Function GetDemandeur(id As Integer) As DataTable
        Dim cmd = New MySqlCommand
        cmd.CommandText = "SELECT * FROM demandeurs WHERE dmdr_id = @id"
        cmd.Connection = Connexion()
        cmd.Parameters.AddWithValue("id", id)
        ' .CommandType = CommandType.Text ??
        Dim Adapter As New MySqlDataAdapter
        Dim dsResultats As New DataSet
        Adapter.SelectCommand = cmd
        Adapter.Fill(dsResultats)
        'Connexion.Close()
        Return dsResultats.Tables(0)
    End Function


    ' version temporaire en attendant les vraies fonctions bdd
    'Function GetPersonnes() As DataTable
    'Dim ds As DataSet
    'Dim dt As DataTable = New DataTable()
    'Dim dr As DataRow
    'Dim ColNom As DataColumn
    'Dim ColPrenom

    '      ColNom = New DataColumn("nom", Type.GetType("System.String"))
    '     ColPrenom = New DataColumn("prenom", Type.GetType("System.String"))
    '    ColNaissance = New DataColumn("naissance", Type.GetType("System.String"))
    '   ColMort = New DataColumn("mort", Type.GetType("System.String"))
    '  ColSepulture = New DataColumn("sepulture", Type.GetType("System.String"))
    ' ColEnterement = New DataColumn("enterement", Type.GetType("System.String"))         'faute d'orthographe
    ' ColExpiration = New DataColumn("expiration", Type.GetType("System.String"))

    '        dt.Columns.Add(ColNom)
    '       dt.Columns.Add(ColPrenom)
    '      dt.Columns.Add(ColNaissance)
    '     dt.Columns.Add(ColMort)
    '    dt.Columns.Add(ColSepulture)
    '   dt.Columns.Add(ColEnterement)
    '  dt.Columns.Add(ColExpiration)

    '    dr = dt.NewRow()
    '       dr("nom") = "dubidon"
    '      dr("prenom") = "albaire"
    '     dr("naissance") = "hier"
    '    dr("mort") = "aujourd'hui"
    '   dr("sepulture") = "tombe"
    ' dr("enterement") = "demain"
    '  dr("expiration") = "un jour"
    '        dt.Rows.Add(dr)
    '
    '   dr = dt.NewRow()
    '  dr("nom") = "nanana"
    ' dr("prenom") = "gudule"
    'dr("naissance") = "19/26/1489"
    ' dr("mort") = "pas encore"
    '  dr("sepulture") = "urne"
    '   dr("enterement") = "à voir"
    ' dr("expiration") = "oui"
    'dt.Rows.Add(dr)
    '
    '   dr = dt.NewRow()
    '  dr("nom") = "azertyu"
    ' dr("prenom") = "qfghjq"
    'dr("naissance") = "21/09/1836"
    '  dr("mort") = "92/63/2836"
    ' dr("sepulture") = "pyramide"
    'dr("enterement") = "24/09/1836"
    'dr("expiration") = "n.f. action d'expirer ou résultat de cette action"
    'dt.Rows.Add(dr)

    'ds.Tables.Add(dt)

    '        Return dt

    'End Function


    'Public Function InsertPers() As Boolean

    '    Dim conn As MySqlConnection = Connecter()
    '    Dim sqlCommand As New MySqlCommand
    '    Dim str_carSql As String

    '    Try
    '        str_carSql = "insert into personne (id, nom, prenom, naissance, mort, sepulture, enterement, expiration) values ('','heu','peutetre','25','34','65','98','20')"
    '        MsgBox(str_carSql)
    '        sqlCommand.Connection = conn
    '        sqlCommand.CommandText = str_carSql
    '        sqlCommand.ExecuteNonQuery()
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '        MsgBox("Error occured: Could not insert record")
    '    End Try

    '    conn.Close()
    'End Function


    ' Pour service PHP
    ' Renvoie du JSON (actuellement) 
    ' à continuer
    Private Function ExecuterCommandeBdd(action As String, Optional data As Object = Nothing, Optional ByRef erreur As BddErreur = Nothing) As Object
        erreur = Nothing
        Dim resultat As Object = Nothing
        Dim JsonPost As Byte()
        JsonPost = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(New With {.action = action, .data = data}))

        Dim req As HttpWebRequest = HttpWebRequest.Create(URL_API)
        req.Method = "POST"
        req.ContentType = "application/json"
        req.ContentLength = JsonPost.Length

        Dim ReqStream As Stream = req.GetRequestStream()
        ReqStream.Write(JsonPost, 0, JsonPost.Length)
        ReqStream.Close()

        Dim rep As WebResponse = req.GetResponse()
        ' À faire : gérer les erreurs de connexion
        ReqStream = rep.GetResponseStream
        Dim lectstream As New StreamReader(ReqStream)
        Dim reptexte As String = lectstream.ReadToEnd()
        If reptexte.Length < 2 Then
            erreur = New BddErreur(ERR_OUTPUT, "Réponse du serveur illisible")
        Else
            Dim CodeReponse As String = reptexte.Substring(0, 2)
            Dim JsonReponse As String = reptexte.Substring(2)
            Select Case CodeReponse
                Case PREFIXE_ERREUR
                    erreur = JsonConvert.DeserializeObject(Of BddErreur)(JsonReponse)
                Case PREFIXE_IDENTIFICATION
                    resultat = JsonConvert.DeserializeObject(Of BddReponseIdentification)(JsonReponse)
                Case Else
                    erreur = New BddErreur(ERR_OUTPUT, "Réponse du serveur illisible")
            End Select
        End If
        If resultat IsNot Nothing Then erreur = New BddErreur(ERR_OK, "Tout va bien.")
        Return resultat

        'Return reptexte
        'rep.Close() ' dispose ?
    End Function

End Module
