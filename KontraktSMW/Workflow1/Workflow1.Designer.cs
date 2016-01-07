using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace masterleasing.Workflows.KontraktSMW.Workflow1
{
    public sealed partial class Workflow1
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind17 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind18 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind19 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind20 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind21 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind22 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind23 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind24 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind25 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition5 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition6 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition7 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition8 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition9 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition10 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition11 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition12 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition13 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition14 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition15 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition16 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition17 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition18 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition19 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition20 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition21 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition22 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition23 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition24 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition25 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition26 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind26 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind27 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind28 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind29 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind30 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind31 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind32 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind33 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind34 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind35 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind36 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind37 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind38 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind39 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind40 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind41 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind42 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind43 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind44 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind45 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind46 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind47 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind48 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind49 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind50 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind51 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind52 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind53 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind54 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind55 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition27 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition28 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition29 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition30 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition31 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition32 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition33 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition34 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition35 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition36 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition37 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition38 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition39 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition40 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition41 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition42 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition43 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition44 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition45 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition46 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition47 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition48 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition49 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition50 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind56 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken6 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken7 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken8 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken9 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken10 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken11 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken12 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken13 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken14 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken15 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken16 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken17 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken18 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken19 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken20 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken21 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken22 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken23 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken24 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken25 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken26 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken27 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken28 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken29 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken30 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken31 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind57 = new System.Workflow.ComponentModel.ActivityBind();
            this.logToHistoryListActivity20 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_Uruchomiony = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity52 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity19 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_UmowaZaakceptowana = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity18 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_WniosekZaakceptowany = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity55 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_OfertaZaakceptowana = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity56 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity27 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity23 = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Stracony = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Uruchomienie = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Umowa = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Wniosek = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Oferta = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Telemarketing = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity29 = new System.Workflow.Activities.SetStateActivity();
            this.logNavigator = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity42 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity41 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity40 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity39 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity38 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity37 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity36 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity35 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity34 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity33 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity32 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity31 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity30 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity28 = new System.Workflow.Activities.SetStateActivity();
            this.Uruchomiony_SendMailAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_SendEmailAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_SendMailAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_MailSendAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.Status_Lead_Else = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Rozliczenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlersActivity7 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.StatusLeadu_Stracony = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Uruchomiony = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Umowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Wniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Telefon = new System.Workflow.Activities.IfElseBranchActivity();
            this.Else2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifRozliczenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifDokumentacja = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifUruchomienie = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAkceptacjaUmowy = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifUmowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifKorektaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifKorektaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifAkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifOdrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifOferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifTelemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWeryfikacja = new System.Workflow.Activities.IfElseBranchActivity();
            this.logToHistoryListActivity4 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity67 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity10 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity21 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity54 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity66 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity9 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity22 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity10 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity51 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity65 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity8 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity18 = new System.Workflow.Activities.SetStateActivity();
            this.StatusUmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_UmowaNiezaakceptowana = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity49 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity24 = new System.Workflow.Activities.SetStateActivity();
            this.StatusUmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_UmowaStracona = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity48 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity20 = new System.Workflow.Activities.SetStateActivity();
            this.StatusUmowa_Uruchomienie = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity4 = new System.Workflow.Activities.IfElseActivity();
            this.Komunikat_UmowaUruchomiona = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity47 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity64 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity7 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity19 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity45 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity63 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity6 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity17 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity43 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity62 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity5 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity16 = new System.Workflow.Activities.SetStateActivity();
            this.StatusWniosek_Stracony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_WniosekOdrzucony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity41 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity15 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity40 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity14 = new System.Workflow.Activities.SetStateActivity();
            this.StatusWniosek_Umowa = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity3 = new System.Workflow.Activities.IfElseActivity();
            this.Komunikat_AkceptacjaWniosku = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity39 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity61 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity4 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity13 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity27 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity60 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity8 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity37 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logErrorMessage = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ErrorHandler = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity7 = new System.Workflow.Activities.SetStateActivity();
            this.StatusOferta_Telefon = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity24 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity6 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity23 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity12 = new System.Workflow.Activities.SetStateActivity();
            this.StatusOferta_Stracony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_OfertaNiezaakceptowana = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity22 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity11 = new System.Workflow.Activities.SetStateActivity();
            this.StatusOferta_Wniosek = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.Komunikat_AkceptacjaOferty = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity21 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity17 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_Stracony = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity59 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity5 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity58 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity10 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Stracony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity34 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity9 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity33 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logERROR_WefyfikacjaInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity57 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ErrorHandler_Weryfikacja = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity31 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity30 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity29 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logERROR_NavigatorInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Navigator_Routing = new System.Workflow.Activities.IfElseActivity();
            this.E = new System.Workflow.Activities.IfElseActivity();
            this.faultHandlerActivity2 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity15 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Dokumentacja_Rozliczenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity14 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Uruchomienie_Dokumentacja = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity13 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.AkceptacjaUmowy_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Uruchomienie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity12 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Umowa_AkceptacjaUmowy = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity11 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.KorektaWniosku_AkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity10 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.AkceptacjaWniosku_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_KorektaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_Umowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity9 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Wniosek_AkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity8 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.KorektaOferty_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity1 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.AkceptacjaOferty_Telemarketing1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_KorektaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Wniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.Odrzucenie_MailSendAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity7 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Oferta_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity6 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Telemarketing_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity4 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity5 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlersActivity6 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity3 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Else = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifEtapNotNull = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlersActivity2 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity25 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity3 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.nRozliczenie_DodajDoRozliczen = new System.Workflow.Activities.CodeActivity();
            this.SetCT_Rozliczenie = new System.Workflow.Activities.CodeActivity();
            this.setState_Rozliczenie = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity11 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.faultHandlersActivity18 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity11 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity53 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged11 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow12 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Dokumentacja = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity9 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Dokumentacja = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity17 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity123 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity50 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged12 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow11 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Uruchomienie = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity10 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Uruchomienie = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity16 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.TestAkceptacjaUmowy = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity46 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged10 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow10 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_AkceptacjaUmowy = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity13 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_AkceptacjaUmowy = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity15 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity9 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity44 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged9 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow9 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Umowa = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity8 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Umowa = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity14 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity8 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity42 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged8 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow8 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_KorektaWniosku = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity12 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Wniosek1 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity13 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity7 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity38 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged7 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow7 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_AkceptacjaWniosku = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity7 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_AkceptacjaWniosku = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity12 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity6 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity26 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged6 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.codeDodajDoRozliczen = new System.Workflow.Activities.CodeActivity();
            this.initializeWorkflow6 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Wniosek = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity6 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Wniosek = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity11 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity5 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity36 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged5 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow5 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_KorektaOferty = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logKorektaOferty = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Oferta1 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity8 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.AkceptacjaOferty_Telemarketing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity25 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged4 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow4 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_AkceptacjaOferty = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity5 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_AkceptacjaOferty = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity26 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity2 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Odrzucony = new System.Workflow.Activities.CodeActivity();
            this.setState_Odrzucony = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.faultHandlersActivity10 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Oferta_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity35 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged2 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow3 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Oferta = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity15 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Oferta = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity9 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Telemarketing_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity32 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged3 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.initializeWorkflow2 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Telemarketing = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity16 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Telemarketing = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity4 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow1 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.logToHistoryListActivity14 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setState_Weryfikacja = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.SetCT_Weryfikacja = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity5 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity28 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged13 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity3 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.TestEtap = new System.Workflow.Activities.IfElseActivity();
            this.logRouter = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.faultHandlersActivity1 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.StatusLead_Rozmowa = new System.Workflow.Activities.CodeActivity();
            this.codeSetup = new System.Workflow.Activities.CodeActivity();
            this.logZainicjowany = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            this.stateInitializationActivity12 = new System.Workflow.Activities.StateInitializationActivity();
            this.Dokumentacja_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity10 = new System.Workflow.Activities.StateInitializationActivity();
            this.Uruchomienie_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity11 = new System.Workflow.Activities.StateInitializationActivity();
            this.AkceptacjaUmowy_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity14 = new System.Workflow.Activities.StateInitializationActivity();
            this.Umowa_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity9 = new System.Workflow.Activities.StateInitializationActivity();
            this.KorektaWniosku_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity13 = new System.Workflow.Activities.StateInitializationActivity();
            this.AkceptacjaWniosku_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity8 = new System.Workflow.Activities.StateInitializationActivity();
            this.Wniosek_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity7 = new System.Workflow.Activities.StateInitializationActivity();
            this.KorektaOferty_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity6 = new System.Workflow.Activities.StateInitializationActivity();
            this.AkceptacjaOferty_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity5 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity2 = new System.Workflow.Activities.StateInitializationActivity();
            this.Oferta_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity4 = new System.Workflow.Activities.StateInitializationActivity();
            this.Telemarketing_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity3 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity1 = new System.Workflow.Activities.StateInitializationActivity();
            this.Weryfikacja_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity15 = new System.Workflow.Activities.StateInitializationActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.End = new System.Workflow.Activities.StateActivity();
            this.Rozliczenie = new System.Workflow.Activities.StateActivity();
            this.Dokumentacja = new System.Workflow.Activities.StateActivity();
            this.Uruchomienie = new System.Workflow.Activities.StateActivity();
            this.AkceptacjaUmowy = new System.Workflow.Activities.StateActivity();
            this.Umowa = new System.Workflow.Activities.StateActivity();
            this.KorektaWniosku = new System.Workflow.Activities.StateActivity();
            this.AkceptacjaWniosku = new System.Workflow.Activities.StateActivity();
            this.Wniosek = new System.Workflow.Activities.StateActivity();
            this.KorektaOferty = new System.Workflow.Activities.StateActivity();
            this.AkceptacjaOferty = new System.Workflow.Activities.StateActivity();
            this.Odrzucenie = new System.Workflow.Activities.StateActivity();
            this.Oferta = new System.Workflow.Activities.StateActivity();
            this.Telemarketing = new System.Workflow.Activities.StateActivity();
            this.Weryfikacja = new System.Workflow.Activities.StateActivity();
            this.Navigator = new System.Workflow.Activities.StateActivity();
            this.Start = new System.Workflow.Activities.StateActivity();
            // 
            // logToHistoryListActivity20
            // 
            this.logToHistoryListActivity20.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity20.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity20.HistoryDescription = "Wiadomość wysłana";
            this.logToHistoryListActivity20.HistoryOutcome = "";
            this.logToHistoryListActivity20.Name = "logToHistoryListActivity20";
            this.logToHistoryListActivity20.OtherData = "";
            this.logToHistoryListActivity20.UserId = -1;
            // 
            // sendEmail_Uruchomiony
            // 
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "Mail_BCC";
            activitybind2.Name = "Workflow1";
            activitybind2.Path = "Mail_Body";
            activitybind3.Name = "Workflow1";
            activitybind3.Path = "Mail_CC";
            correlationtoken1.Name = "myWorkflowToken";
            correlationtoken1.OwnerActivityName = "Uruchomienie";
            this.sendEmail_Uruchomiony.CorrelationToken = correlationtoken1;
            activitybind4.Name = "Workflow1";
            activitybind4.Path = "Mail_From";
            this.sendEmail_Uruchomiony.Headers = null;
            this.sendEmail_Uruchomiony.IncludeStatus = false;
            this.sendEmail_Uruchomiony.Name = "sendEmail_Uruchomiony";
            activitybind5.Name = "Workflow1";
            activitybind5.Path = "Mail_Subject";
            activitybind6.Name = "Workflow1";
            activitybind6.Path = "Mail_To";
            this.sendEmail_Uruchomiony.MethodInvoking += new System.EventHandler(this.sendEmail_Uruchomiony_MethodInvoking);
            this.sendEmail_Uruchomiony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.sendEmail_Uruchomiony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.sendEmail_Uruchomiony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.sendEmail_Uruchomiony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.sendEmail_Uruchomiony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.sendEmail_Uruchomiony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            // 
            // logToHistoryListActivity52
            // 
            this.logToHistoryListActivity52.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity52.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity52.HistoryDescription = "Uruchomiony_SendMailAllowed";
            this.logToHistoryListActivity52.HistoryOutcome = "";
            this.logToHistoryListActivity52.Name = "logToHistoryListActivity52";
            this.logToHistoryListActivity52.OtherData = "";
            this.logToHistoryListActivity52.UserId = -1;
            // 
            // logToHistoryListActivity19
            // 
            this.logToHistoryListActivity19.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity19.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity19.HistoryDescription = "Wiadomość wysłana";
            this.logToHistoryListActivity19.HistoryOutcome = "";
            this.logToHistoryListActivity19.Name = "logToHistoryListActivity19";
            this.logToHistoryListActivity19.OtherData = "";
            this.logToHistoryListActivity19.UserId = -1;
            // 
            // sendEmail_UmowaZaakceptowana
            // 
            activitybind7.Name = "Workflow1";
            activitybind7.Path = "Mail_BCC";
            activitybind8.Name = "Workflow1";
            activitybind8.Path = "Mail_Body";
            activitybind9.Name = "Workflow1";
            activitybind9.Path = "Mail_CC";
            correlationtoken2.Name = "myWorkflowToken";
            correlationtoken2.OwnerActivityName = "AkceptacjaUmowy";
            this.sendEmail_UmowaZaakceptowana.CorrelationToken = correlationtoken2;
            activitybind10.Name = "Workflow1";
            activitybind10.Path = "Mail_From";
            this.sendEmail_UmowaZaakceptowana.Headers = null;
            this.sendEmail_UmowaZaakceptowana.IncludeStatus = false;
            this.sendEmail_UmowaZaakceptowana.Name = "sendEmail_UmowaZaakceptowana";
            activitybind11.Name = "Workflow1";
            activitybind11.Path = "Mail_Subject";
            activitybind12.Name = "Workflow1";
            activitybind12.Path = "Mail_To";
            this.sendEmail_UmowaZaakceptowana.MethodInvoking += new System.EventHandler(this.sendEmail_UmowaZaakceptowana_MethodInvoking);
            this.sendEmail_UmowaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.sendEmail_UmowaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.sendEmail_UmowaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            this.sendEmail_UmowaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            this.sendEmail_UmowaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            this.sendEmail_UmowaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
            // 
            // logToHistoryListActivity18
            // 
            this.logToHistoryListActivity18.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity18.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity18.HistoryDescription = "Wiadomość wysłana";
            this.logToHistoryListActivity18.HistoryOutcome = "";
            this.logToHistoryListActivity18.Name = "logToHistoryListActivity18";
            this.logToHistoryListActivity18.OtherData = "";
            this.logToHistoryListActivity18.UserId = -1;
            // 
            // sendEmail_WniosekZaakceptowany
            // 
            activitybind13.Name = "Workflow1";
            activitybind13.Path = "Mail_BCC";
            activitybind14.Name = "Workflow1";
            activitybind14.Path = "Mail_Body";
            activitybind15.Name = "Workflow1";
            activitybind15.Path = "Mail_CC";
            correlationtoken3.Name = "myWorkflowToken";
            correlationtoken3.OwnerActivityName = "AkceptacjaWniosku";
            this.sendEmail_WniosekZaakceptowany.CorrelationToken = correlationtoken3;
            activitybind16.Name = "Workflow1";
            activitybind16.Path = "Mail_From";
            this.sendEmail_WniosekZaakceptowany.Headers = null;
            this.sendEmail_WniosekZaakceptowany.IncludeStatus = false;
            this.sendEmail_WniosekZaakceptowany.Name = "sendEmail_WniosekZaakceptowany";
            activitybind17.Name = "Workflow1";
            activitybind17.Path = "Mail_Subject";
            activitybind18.Name = "Workflow1";
            activitybind18.Path = "Mail_To";
            this.sendEmail_WniosekZaakceptowany.MethodInvoking += new System.EventHandler(this.sendEmail_WniosekZaakceptowany_MethodInvoking);
            this.sendEmail_WniosekZaakceptowany.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
            this.sendEmail_WniosekZaakceptowany.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
            this.sendEmail_WniosekZaakceptowany.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind17)));
            this.sendEmail_WniosekZaakceptowany.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind18)));
            this.sendEmail_WniosekZaakceptowany.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
            this.sendEmail_WniosekZaakceptowany.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
            // 
            // logToHistoryListActivity55
            // 
            this.logToHistoryListActivity55.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity55.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity55.HistoryDescription = "AkceptacjaWniosku_SendMailAllowed";
            this.logToHistoryListActivity55.HistoryOutcome = "";
            this.logToHistoryListActivity55.Name = "logToHistoryListActivity55";
            this.logToHistoryListActivity55.OtherData = "";
            this.logToHistoryListActivity55.UserId = -1;
            // 
            // logToHistoryListActivity1
            // 
            this.logToHistoryListActivity1.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity1.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity1.HistoryDescription = "Wiadomość wysłana";
            this.logToHistoryListActivity1.HistoryOutcome = "";
            this.logToHistoryListActivity1.Name = "logToHistoryListActivity1";
            this.logToHistoryListActivity1.OtherData = "";
            this.logToHistoryListActivity1.UserId = -1;
            // 
            // sendEmail_OfertaZaakceptowana
            // 
            activitybind19.Name = "Workflow1";
            activitybind19.Path = "Mail_BCC";
            activitybind20.Name = "Workflow1";
            activitybind20.Path = "Mail_Body";
            activitybind21.Name = "Workflow1";
            activitybind21.Path = "Mail_CC";
            correlationtoken4.Name = "myWorkflowToken";
            correlationtoken4.OwnerActivityName = "AkceptacjaOferty";
            this.sendEmail_OfertaZaakceptowana.CorrelationToken = correlationtoken4;
            activitybind22.Name = "Workflow1";
            activitybind22.Path = "Mail_From";
            this.sendEmail_OfertaZaakceptowana.Headers = null;
            this.sendEmail_OfertaZaakceptowana.IncludeStatus = false;
            this.sendEmail_OfertaZaakceptowana.Name = "sendEmail_OfertaZaakceptowana";
            activitybind23.Name = "Workflow1";
            activitybind23.Path = "Mail_Subject";
            activitybind24.Name = "Workflow1";
            activitybind24.Path = "Mail_To";
            this.sendEmail_OfertaZaakceptowana.MethodInvoking += new System.EventHandler(this.sendEmail_OfertaZaakceptowana_MethodInvoking);
            this.sendEmail_OfertaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind19)));
            this.sendEmail_OfertaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind20)));
            this.sendEmail_OfertaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind23)));
            this.sendEmail_OfertaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind24)));
            this.sendEmail_OfertaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind21)));
            this.sendEmail_OfertaZaakceptowana.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind22)));
            // 
            // logToHistoryListActivity56
            // 
            this.logToHistoryListActivity56.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity56.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity56.HistoryDescription = "AkceptacjaOferty_MailSendAllowed";
            this.logToHistoryListActivity56.HistoryOutcome = "";
            this.logToHistoryListActivity56.Name = "logToHistoryListActivity56";
            this.logToHistoryListActivity56.OtherData = "";
            this.logToHistoryListActivity56.UserId = -1;
            // 
            // setStateActivity27
            // 
            this.setStateActivity27.Name = "setStateActivity27";
            this.setStateActivity27.TargetStateName = "Weryfikacja";
            // 
            // setStateActivity23
            // 
            this.setStateActivity23.Name = "setStateActivity23";
            this.setStateActivity23.TargetStateName = "Rozliczenie";
            // 
            // Navigator_Stracony
            // 
            this.Navigator_Stracony.Name = "Navigator_Stracony";
            this.Navigator_Stracony.TargetStateName = "Odrzucenie";
            // 
            // Navigator_Uruchomienie
            // 
            this.Navigator_Uruchomienie.Name = "Navigator_Uruchomienie";
            this.Navigator_Uruchomienie.TargetStateName = "Uruchomienie";
            // 
            // Navigator_Umowa
            // 
            this.Navigator_Umowa.Name = "Navigator_Umowa";
            this.Navigator_Umowa.TargetStateName = "Umowa";
            // 
            // Navigator_Wniosek
            // 
            this.Navigator_Wniosek.Name = "Navigator_Wniosek";
            this.Navigator_Wniosek.TargetStateName = "Wniosek";
            // 
            // Navigator_Oferta
            // 
            this.Navigator_Oferta.Name = "Navigator_Oferta";
            this.Navigator_Oferta.TargetStateName = "Oferta";
            // 
            // Navigator_Telemarketing
            // 
            this.Navigator_Telemarketing.Name = "Navigator_Telemarketing";
            this.Navigator_Telemarketing.TargetStateName = "Telemarketing";
            // 
            // setStateActivity29
            // 
            this.setStateActivity29.Name = "setStateActivity29";
            this.setStateActivity29.TargetStateName = "Weryfikacja";
            // 
            // logNavigator
            // 
            this.logNavigator.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logNavigator.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logNavigator.HistoryDescription = "Navigator";
            activitybind25.Name = "Workflow1";
            activitybind25.Path = "logNavigator_HistoryOutcome";
            this.logNavigator.Name = "logNavigator";
            this.logNavigator.OtherData = "";
            this.logNavigator.UserId = -1;
            this.logNavigator.MethodInvoking += new System.EventHandler(this.SetNavigatorMessage);
            this.logNavigator.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind25)));
            // 
            // setStateActivity42
            // 
            this.setStateActivity42.Name = "setStateActivity42";
            this.setStateActivity42.TargetStateName = "Rozliczenie";
            // 
            // setStateActivity41
            // 
            this.setStateActivity41.Name = "setStateActivity41";
            this.setStateActivity41.TargetStateName = "Dokumentacja";
            // 
            // setStateActivity40
            // 
            this.setStateActivity40.Name = "setStateActivity40";
            this.setStateActivity40.TargetStateName = "Uruchomienie";
            // 
            // setStateActivity39
            // 
            this.setStateActivity39.Name = "setStateActivity39";
            this.setStateActivity39.TargetStateName = "AkceptacjaUmowy";
            // 
            // setStateActivity38
            // 
            this.setStateActivity38.Name = "setStateActivity38";
            this.setStateActivity38.TargetStateName = "Umowa";
            // 
            // setStateActivity37
            // 
            this.setStateActivity37.Name = "setStateActivity37";
            this.setStateActivity37.TargetStateName = "KorektaWniosku";
            // 
            // setStateActivity36
            // 
            this.setStateActivity36.Name = "setStateActivity36";
            this.setStateActivity36.TargetStateName = "AkceptacjaWniosku";
            // 
            // setStateActivity35
            // 
            this.setStateActivity35.Name = "setStateActivity35";
            this.setStateActivity35.TargetStateName = "Wniosek";
            // 
            // setStateActivity34
            // 
            this.setStateActivity34.Name = "setStateActivity34";
            this.setStateActivity34.TargetStateName = "KorektaOferty";
            // 
            // setStateActivity33
            // 
            this.setStateActivity33.Name = "setStateActivity33";
            this.setStateActivity33.TargetStateName = "AkceptacjaOferty";
            // 
            // setStateActivity32
            // 
            this.setStateActivity32.Name = "setStateActivity32";
            this.setStateActivity32.TargetStateName = "Odrzucenie";
            // 
            // setStateActivity31
            // 
            this.setStateActivity31.Name = "setStateActivity31";
            this.setStateActivity31.TargetStateName = "Oferta";
            // 
            // setStateActivity30
            // 
            this.setStateActivity30.Name = "setStateActivity30";
            this.setStateActivity30.TargetStateName = "Telemarketing";
            // 
            // setStateActivity28
            // 
            this.setStateActivity28.Name = "setStateActivity28";
            this.setStateActivity28.TargetStateName = "Weryfikacja";
            // 
            // Uruchomiony_SendMailAllowed
            // 
            this.Uruchomiony_SendMailAllowed.Activities.Add(this.logToHistoryListActivity52);
            this.Uruchomiony_SendMailAllowed.Activities.Add(this.sendEmail_Uruchomiony);
            this.Uruchomiony_SendMailAllowed.Activities.Add(this.logToHistoryListActivity20);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsUruchomiony_SendMailAllowed);
            this.Uruchomiony_SendMailAllowed.Condition = codecondition1;
            this.Uruchomiony_SendMailAllowed.Name = "Uruchomiony_SendMailAllowed";
            // 
            // AkceptacjaUmowy_SendEmailAllowed
            // 
            this.AkceptacjaUmowy_SendEmailAllowed.Activities.Add(this.sendEmail_UmowaZaakceptowana);
            this.AkceptacjaUmowy_SendEmailAllowed.Activities.Add(this.logToHistoryListActivity19);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_SendEmailAllowed);
            this.AkceptacjaUmowy_SendEmailAllowed.Condition = codecondition2;
            this.AkceptacjaUmowy_SendEmailAllowed.Name = "AkceptacjaUmowy_SendEmailAllowed";
            // 
            // AkceptacjaWniosku_SendMailAllowed
            // 
            this.AkceptacjaWniosku_SendMailAllowed.Activities.Add(this.logToHistoryListActivity55);
            this.AkceptacjaWniosku_SendMailAllowed.Activities.Add(this.sendEmail_WniosekZaakceptowany);
            this.AkceptacjaWniosku_SendMailAllowed.Activities.Add(this.logToHistoryListActivity18);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_SendMailAllowed);
            this.AkceptacjaWniosku_SendMailAllowed.Condition = codecondition3;
            this.AkceptacjaWniosku_SendMailAllowed.Name = "AkceptacjaWniosku_SendMailAllowed";
            // 
            // AkceptacjaOferty_MailSendAllowed
            // 
            this.AkceptacjaOferty_MailSendAllowed.Activities.Add(this.logToHistoryListActivity56);
            this.AkceptacjaOferty_MailSendAllowed.Activities.Add(this.sendEmail_OfertaZaakceptowana);
            this.AkceptacjaOferty_MailSendAllowed.Activities.Add(this.logToHistoryListActivity1);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_MailSendAllowed);
            this.AkceptacjaOferty_MailSendAllowed.Condition = codecondition4;
            this.AkceptacjaOferty_MailSendAllowed.Name = "AkceptacjaOferty_MailSendAllowed";
            // 
            // Status_Lead_Else
            // 
            this.Status_Lead_Else.Activities.Add(this.setStateActivity27);
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_ElseIf);
            this.Status_Lead_Else.Condition = codecondition5;
            this.Status_Lead_Else.Name = "Status_Lead_Else";
            // 
            // StatusLeadu_Rozliczenie
            // 
            this.StatusLeadu_Rozliczenie.Activities.Add(this.setStateActivity23);
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Rozliczenie);
            this.StatusLeadu_Rozliczenie.Condition = codecondition6;
            this.StatusLeadu_Rozliczenie.Name = "StatusLeadu_Rozliczenie";
            // 
            // faultHandlersActivity7
            // 
            this.faultHandlersActivity7.Name = "faultHandlersActivity7";
            // 
            // StatusLeadu_Stracony
            // 
            this.StatusLeadu_Stracony.Activities.Add(this.Navigator_Stracony);
            codecondition7.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Stracony);
            this.StatusLeadu_Stracony.Condition = codecondition7;
            this.StatusLeadu_Stracony.Name = "StatusLeadu_Stracony";
            // 
            // StatusLeadu_Uruchomiony
            // 
            this.StatusLeadu_Uruchomiony.Activities.Add(this.Navigator_Uruchomienie);
            codecondition8.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Uruchomiony);
            this.StatusLeadu_Uruchomiony.Condition = codecondition8;
            this.StatusLeadu_Uruchomiony.Name = "StatusLeadu_Uruchomiony";
            // 
            // StatusLeadu_Umowa
            // 
            this.StatusLeadu_Umowa.Activities.Add(this.Navigator_Umowa);
            codecondition9.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Umowa);
            this.StatusLeadu_Umowa.Condition = codecondition9;
            this.StatusLeadu_Umowa.Name = "StatusLeadu_Umowa";
            // 
            // StatusLeadu_Wniosek
            // 
            this.StatusLeadu_Wniosek.Activities.Add(this.Navigator_Wniosek);
            codecondition10.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Wniosek);
            this.StatusLeadu_Wniosek.Condition = codecondition10;
            this.StatusLeadu_Wniosek.Name = "StatusLeadu_Wniosek";
            // 
            // StatusLeadu_Oferta
            // 
            this.StatusLeadu_Oferta.Activities.Add(this.Navigator_Oferta);
            codecondition11.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Oferta);
            this.StatusLeadu_Oferta.Condition = codecondition11;
            this.StatusLeadu_Oferta.Name = "StatusLeadu_Oferta";
            // 
            // StatusLeadu_Telefon
            // 
            this.StatusLeadu_Telefon.Activities.Add(this.Navigator_Telemarketing);
            codecondition12.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Telefon);
            this.StatusLeadu_Telefon.Condition = codecondition12;
            this.StatusLeadu_Telefon.Name = "StatusLeadu_Telefon";
            // 
            // Else2
            // 
            this.Else2.Activities.Add(this.logNavigator);
            this.Else2.Activities.Add(this.setStateActivity29);
            this.Else2.Name = "Else2";
            // 
            // ifRozliczenie
            // 
            this.ifRozliczenie.Activities.Add(this.setStateActivity42);
            codecondition13.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isRozliczenie);
            this.ifRozliczenie.Condition = codecondition13;
            this.ifRozliczenie.Name = "ifRozliczenie";
            // 
            // ifDokumentacja
            // 
            this.ifDokumentacja.Activities.Add(this.setStateActivity41);
            codecondition14.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isDokumentacja);
            this.ifDokumentacja.Condition = codecondition14;
            this.ifDokumentacja.Name = "ifDokumentacja";
            // 
            // ifUruchomienie
            // 
            this.ifUruchomienie.Activities.Add(this.setStateActivity40);
            codecondition15.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isUruchomienie);
            this.ifUruchomienie.Condition = codecondition15;
            this.ifUruchomienie.Name = "ifUruchomienie";
            // 
            // ifAkceptacjaUmowy
            // 
            this.ifAkceptacjaUmowy.Activities.Add(this.setStateActivity39);
            codecondition16.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isAkceptacjaUmowy);
            this.ifAkceptacjaUmowy.Condition = codecondition16;
            this.ifAkceptacjaUmowy.Name = "ifAkceptacjaUmowy";
            // 
            // ifUmowa
            // 
            this.ifUmowa.Activities.Add(this.setStateActivity38);
            codecondition17.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isUmowa);
            this.ifUmowa.Condition = codecondition17;
            this.ifUmowa.Name = "ifUmowa";
            // 
            // ifKorektaWniosku
            // 
            this.ifKorektaWniosku.Activities.Add(this.setStateActivity37);
            codecondition18.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isKorektaWniosku);
            this.ifKorektaWniosku.Condition = codecondition18;
            this.ifKorektaWniosku.Name = "ifKorektaWniosku";
            // 
            // ifAkceptacjaWniosku
            // 
            this.ifAkceptacjaWniosku.Activities.Add(this.setStateActivity36);
            codecondition19.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isAkceptacjaWniosku);
            this.ifAkceptacjaWniosku.Condition = codecondition19;
            this.ifAkceptacjaWniosku.Name = "ifAkceptacjaWniosku";
            // 
            // ifWniosek
            // 
            this.ifWniosek.Activities.Add(this.setStateActivity35);
            codecondition20.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isWniosek);
            this.ifWniosek.Condition = codecondition20;
            this.ifWniosek.Name = "ifWniosek";
            // 
            // ifKorektaOferty
            // 
            this.ifKorektaOferty.Activities.Add(this.setStateActivity34);
            codecondition21.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isKorektaOferty);
            this.ifKorektaOferty.Condition = codecondition21;
            this.ifKorektaOferty.Name = "ifKorektaOferty";
            // 
            // ifAkceptacjaOferty
            // 
            this.ifAkceptacjaOferty.Activities.Add(this.setStateActivity33);
            codecondition22.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isAkceptacjaOferty);
            this.ifAkceptacjaOferty.Condition = codecondition22;
            this.ifAkceptacjaOferty.Name = "ifAkceptacjaOferty";
            // 
            // ifOdrzucenie
            // 
            this.ifOdrzucenie.Activities.Add(this.setStateActivity32);
            codecondition23.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isOdrzucenie);
            this.ifOdrzucenie.Condition = codecondition23;
            this.ifOdrzucenie.Name = "ifOdrzucenie";
            // 
            // ifOferta
            // 
            this.ifOferta.Activities.Add(this.setStateActivity31);
            codecondition24.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isOferta);
            this.ifOferta.Condition = codecondition24;
            this.ifOferta.Name = "ifOferta";
            // 
            // ifTelemarketing
            // 
            this.ifTelemarketing.Activities.Add(this.setStateActivity30);
            codecondition25.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isTelemarketing);
            this.ifTelemarketing.Condition = codecondition25;
            this.ifTelemarketing.Name = "ifTelemarketing";
            // 
            // ifWeryfikacja
            // 
            this.ifWeryfikacja.Activities.Add(this.setStateActivity28);
            codecondition26.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isWeryfikacja);
            this.ifWeryfikacja.Condition = codecondition26;
            this.ifWeryfikacja.Name = "ifWeryfikacja";
            // 
            // logToHistoryListActivity4
            // 
            this.logToHistoryListActivity4.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity4.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity4.HistoryDescription = "SetCT_Rozliczenie_ExecuteCode";
            this.logToHistoryListActivity4.HistoryOutcome = "ERR";
            this.logToHistoryListActivity4.Name = "logToHistoryListActivity4";
            this.logToHistoryListActivity4.OtherData = "";
            this.logToHistoryListActivity4.UserId = -1;
            // 
            // logToHistoryListActivity67
            // 
            this.logToHistoryListActivity67.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity67.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind26.Name = "Workflow1";
            activitybind26.Path = "logErrorMessage_HistoryDescription";
            activitybind27.Name = "Workflow1";
            activitybind27.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity67.Name = "logToHistoryListActivity67";
            this.logToHistoryListActivity67.OtherData = "";
            this.logToHistoryListActivity67.UserId = -1;
            this.logToHistoryListActivity67.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind26)));
            this.logToHistoryListActivity67.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind27)));
            // 
            // codeActivity10
            // 
            this.codeActivity10.Name = "codeActivity10";
            this.codeActivity10.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity21
            // 
            this.setStateActivity21.Name = "setStateActivity21";
            this.setStateActivity21.TargetStateName = "Rozliczenie";
            // 
            // logToHistoryListActivity54
            // 
            this.logToHistoryListActivity54.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity54.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity54.HistoryDescription = "Dokumentacja_Rozliczenie";
            this.logToHistoryListActivity54.HistoryOutcome = "";
            this.logToHistoryListActivity54.Name = "logToHistoryListActivity54";
            this.logToHistoryListActivity54.OtherData = "";
            this.logToHistoryListActivity54.UserId = -1;
            // 
            // logToHistoryListActivity66
            // 
            this.logToHistoryListActivity66.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity66.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind28.Name = "Workflow1";
            activitybind28.Path = "logErrorMessage_HistoryDescription";
            activitybind29.Name = "Workflow1";
            activitybind29.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity66.Name = "logToHistoryListActivity66";
            this.logToHistoryListActivity66.OtherData = "";
            this.logToHistoryListActivity66.UserId = -1;
            this.logToHistoryListActivity66.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind28)));
            this.logToHistoryListActivity66.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind29)));
            // 
            // codeActivity9
            // 
            this.codeActivity9.Name = "codeActivity9";
            this.codeActivity9.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity22
            // 
            this.setStateActivity22.Name = "setStateActivity22";
            this.setStateActivity22.TargetStateName = "Dokumentacja";
            // 
            // ifElseActivity10
            // 
            this.ifElseActivity10.Activities.Add(this.Uruchomiony_SendMailAllowed);
            this.ifElseActivity10.Name = "ifElseActivity10";
            // 
            // logToHistoryListActivity51
            // 
            this.logToHistoryListActivity51.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity51.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity51.HistoryDescription = "Uruchomienie_Dokumentacja";
            this.logToHistoryListActivity51.HistoryOutcome = "";
            this.logToHistoryListActivity51.Name = "logToHistoryListActivity51";
            this.logToHistoryListActivity51.OtherData = "";
            this.logToHistoryListActivity51.UserId = -1;
            // 
            // logToHistoryListActivity65
            // 
            this.logToHistoryListActivity65.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity65.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind30.Name = "Workflow1";
            activitybind30.Path = "logErrorMessage_HistoryDescription";
            activitybind31.Name = "Workflow1";
            activitybind31.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity65.Name = "logToHistoryListActivity65";
            this.logToHistoryListActivity65.OtherData = "";
            this.logToHistoryListActivity65.UserId = -1;
            this.logToHistoryListActivity65.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind30)));
            this.logToHistoryListActivity65.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind31)));
            // 
            // codeActivity8
            // 
            this.codeActivity8.Name = "codeActivity8";
            this.codeActivity8.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity18
            // 
            this.setStateActivity18.Name = "setStateActivity18";
            this.setStateActivity18.TargetStateName = "Telemarketing";
            // 
            // StatusUmowa_Telefon
            // 
            this.StatusUmowa_Telefon.Name = "StatusUmowa_Telefon";
            this.StatusUmowa_Telefon.ExecuteCode += new System.EventHandler(this.StatusUmowa_Telefon_ExecuteCode);
            // 
            // Komunikat_UmowaNiezaakceptowana
            // 
            this.Komunikat_UmowaNiezaakceptowana.Enabled = false;
            this.Komunikat_UmowaNiezaakceptowana.Name = "Komunikat_UmowaNiezaakceptowana";
            this.Komunikat_UmowaNiezaakceptowana.ExecuteCode += new System.EventHandler(this.Komunikat_UmowaNiezaakceptowana_ExecuteCode);
            // 
            // logToHistoryListActivity49
            // 
            this.logToHistoryListActivity49.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity49.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity49.HistoryDescription = "AkceptacjaUmowy_Telemarketing";
            this.logToHistoryListActivity49.HistoryOutcome = "";
            this.logToHistoryListActivity49.Name = "logToHistoryListActivity49";
            this.logToHistoryListActivity49.OtherData = "";
            this.logToHistoryListActivity49.UserId = -1;
            // 
            // setStateActivity24
            // 
            this.setStateActivity24.Name = "setStateActivity24";
            this.setStateActivity24.TargetStateName = "Odrzucenie";
            // 
            // StatusUmowa_Stracony
            // 
            this.StatusUmowa_Stracony.Name = "StatusUmowa_Stracony";
            this.StatusUmowa_Stracony.ExecuteCode += new System.EventHandler(this.StatusUmowa_Stracony_ExecuteCode);
            // 
            // Komunikat_UmowaStracona
            // 
            this.Komunikat_UmowaStracona.Enabled = false;
            this.Komunikat_UmowaStracona.Name = "Komunikat_UmowaStracona";
            this.Komunikat_UmowaStracona.ExecuteCode += new System.EventHandler(this.Komunikat_UmowaStracona_ExecuteCode);
            // 
            // logToHistoryListActivity48
            // 
            this.logToHistoryListActivity48.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity48.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity48.HistoryDescription = "AkceptacjaUmowy_Odrzucenie";
            this.logToHistoryListActivity48.HistoryOutcome = "";
            this.logToHistoryListActivity48.Name = "logToHistoryListActivity48";
            this.logToHistoryListActivity48.OtherData = "";
            this.logToHistoryListActivity48.UserId = -1;
            // 
            // setStateActivity20
            // 
            this.setStateActivity20.Name = "setStateActivity20";
            this.setStateActivity20.TargetStateName = "Uruchomienie";
            // 
            // StatusUmowa_Uruchomienie
            // 
            this.StatusUmowa_Uruchomienie.Name = "StatusUmowa_Uruchomienie";
            this.StatusUmowa_Uruchomienie.ExecuteCode += new System.EventHandler(this.StatusUmowa_Uruchomienie_ExecuteCode);
            // 
            // ifElseActivity4
            // 
            this.ifElseActivity4.Activities.Add(this.AkceptacjaUmowy_SendEmailAllowed);
            this.ifElseActivity4.Name = "ifElseActivity4";
            // 
            // Komunikat_UmowaUruchomiona
            // 
            this.Komunikat_UmowaUruchomiona.Enabled = false;
            this.Komunikat_UmowaUruchomiona.Name = "Komunikat_UmowaUruchomiona";
            this.Komunikat_UmowaUruchomiona.ExecuteCode += new System.EventHandler(this.Komunikat_UmowaUruchomiona_ExecuteCode);
            // 
            // logToHistoryListActivity47
            // 
            this.logToHistoryListActivity47.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity47.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity47.HistoryDescription = "AkceptacjaUmowy_Uruchomienie";
            this.logToHistoryListActivity47.HistoryOutcome = "";
            this.logToHistoryListActivity47.Name = "logToHistoryListActivity47";
            this.logToHistoryListActivity47.OtherData = "";
            this.logToHistoryListActivity47.UserId = -1;
            // 
            // logToHistoryListActivity64
            // 
            this.logToHistoryListActivity64.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity64.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind32.Name = "Workflow1";
            activitybind32.Path = "logErrorMessage_HistoryDescription";
            activitybind33.Name = "Workflow1";
            activitybind33.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity64.Name = "logToHistoryListActivity64";
            this.logToHistoryListActivity64.OtherData = "";
            this.logToHistoryListActivity64.UserId = -1;
            this.logToHistoryListActivity64.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind32)));
            this.logToHistoryListActivity64.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind33)));
            // 
            // codeActivity7
            // 
            this.codeActivity7.Name = "codeActivity7";
            this.codeActivity7.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity19
            // 
            this.setStateActivity19.Name = "setStateActivity19";
            this.setStateActivity19.TargetStateName = "AkceptacjaUmowy";
            // 
            // logToHistoryListActivity45
            // 
            this.logToHistoryListActivity45.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity45.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity45.HistoryDescription = "Umowa_AkceptacjaUmowy";
            this.logToHistoryListActivity45.HistoryOutcome = "";
            this.logToHistoryListActivity45.Name = "logToHistoryListActivity45";
            this.logToHistoryListActivity45.OtherData = "";
            this.logToHistoryListActivity45.UserId = -1;
            // 
            // logToHistoryListActivity63
            // 
            this.logToHistoryListActivity63.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity63.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind34.Name = "Workflow1";
            activitybind34.Path = "logErrorMessage_HistoryDescription";
            activitybind35.Name = "Workflow1";
            activitybind35.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity63.Name = "logToHistoryListActivity63";
            this.logToHistoryListActivity63.OtherData = "";
            this.logToHistoryListActivity63.UserId = -1;
            this.logToHistoryListActivity63.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind34)));
            this.logToHistoryListActivity63.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind35)));
            // 
            // codeActivity6
            // 
            this.codeActivity6.Name = "codeActivity6";
            this.codeActivity6.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity17
            // 
            this.setStateActivity17.Name = "setStateActivity17";
            this.setStateActivity17.TargetStateName = "AkceptacjaWniosku";
            // 
            // logToHistoryListActivity43
            // 
            this.logToHistoryListActivity43.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity43.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity43.HistoryDescription = "KorektaWniosku_AkceptacjaWniosku";
            this.logToHistoryListActivity43.HistoryOutcome = "";
            this.logToHistoryListActivity43.Name = "logToHistoryListActivity43";
            this.logToHistoryListActivity43.OtherData = "";
            this.logToHistoryListActivity43.UserId = -1;
            // 
            // logToHistoryListActivity62
            // 
            this.logToHistoryListActivity62.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity62.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind36.Name = "Workflow1";
            activitybind36.Path = "logErrorMessage_HistoryDescription";
            activitybind37.Name = "Workflow1";
            activitybind37.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity62.Name = "logToHistoryListActivity62";
            this.logToHistoryListActivity62.OtherData = "";
            this.logToHistoryListActivity62.UserId = -1;
            this.logToHistoryListActivity62.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind36)));
            this.logToHistoryListActivity62.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind37)));
            // 
            // codeActivity5
            // 
            this.codeActivity5.Name = "codeActivity5";
            this.codeActivity5.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity16
            // 
            this.setStateActivity16.Name = "setStateActivity16";
            this.setStateActivity16.TargetStateName = "Odrzucenie";
            // 
            // StatusWniosek_Stracony
            // 
            this.StatusWniosek_Stracony.Name = "StatusWniosek_Stracony";
            this.StatusWniosek_Stracony.ExecuteCode += new System.EventHandler(this.StatusWniosek_Stracony_ExecuteCode);
            // 
            // Komunikat_WniosekOdrzucony
            // 
            this.Komunikat_WniosekOdrzucony.Enabled = false;
            this.Komunikat_WniosekOdrzucony.Name = "Komunikat_WniosekOdrzucony";
            this.Komunikat_WniosekOdrzucony.ExecuteCode += new System.EventHandler(this.Komunikat_WniosekOdrzucony_ExecuteCode);
            // 
            // logToHistoryListActivity41
            // 
            this.logToHistoryListActivity41.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity41.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity41.HistoryDescription = "AkceptacjaWniosku_Odrzucenie";
            this.logToHistoryListActivity41.HistoryOutcome = "";
            this.logToHistoryListActivity41.Name = "logToHistoryListActivity41";
            this.logToHistoryListActivity41.OtherData = "";
            this.logToHistoryListActivity41.UserId = -1;
            // 
            // setStateActivity15
            // 
            this.setStateActivity15.Name = "setStateActivity15";
            this.setStateActivity15.TargetStateName = "KorektaWniosku";
            // 
            // logToHistoryListActivity40
            // 
            this.logToHistoryListActivity40.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity40.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity40.HistoryDescription = "AkceptacjaWniosku_KorektaWniosku";
            this.logToHistoryListActivity40.HistoryOutcome = "";
            this.logToHistoryListActivity40.Name = "logToHistoryListActivity40";
            this.logToHistoryListActivity40.OtherData = "";
            this.logToHistoryListActivity40.UserId = -1;
            // 
            // setStateActivity14
            // 
            this.setStateActivity14.Name = "setStateActivity14";
            this.setStateActivity14.TargetStateName = "Umowa";
            // 
            // StatusWniosek_Umowa
            // 
            this.StatusWniosek_Umowa.Name = "StatusWniosek_Umowa";
            this.StatusWniosek_Umowa.ExecuteCode += new System.EventHandler(this.StatusWniosek_Umowa_ExecuteCode);
            // 
            // ifElseActivity3
            // 
            this.ifElseActivity3.Activities.Add(this.AkceptacjaWniosku_SendMailAllowed);
            this.ifElseActivity3.Name = "ifElseActivity3";
            // 
            // Komunikat_AkceptacjaWniosku
            // 
            this.Komunikat_AkceptacjaWniosku.Enabled = false;
            this.Komunikat_AkceptacjaWniosku.Name = "Komunikat_AkceptacjaWniosku";
            this.Komunikat_AkceptacjaWniosku.ExecuteCode += new System.EventHandler(this.Komunikat_AkceptacjaWniosku_ExecuteCode);
            // 
            // logToHistoryListActivity39
            // 
            this.logToHistoryListActivity39.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity39.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity39.HistoryDescription = "AkceptacjaWniosku_Umowa";
            this.logToHistoryListActivity39.HistoryOutcome = "";
            this.logToHistoryListActivity39.Name = "logToHistoryListActivity39";
            this.logToHistoryListActivity39.OtherData = "";
            this.logToHistoryListActivity39.UserId = -1;
            // 
            // logToHistoryListActivity61
            // 
            this.logToHistoryListActivity61.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity61.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind38.Name = "Workflow1";
            activitybind38.Path = "logErrorMessage_HistoryDescription";
            activitybind39.Name = "Workflow1";
            activitybind39.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity61.Name = "logToHistoryListActivity61";
            this.logToHistoryListActivity61.OtherData = "";
            this.logToHistoryListActivity61.UserId = -1;
            this.logToHistoryListActivity61.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind38)));
            this.logToHistoryListActivity61.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind39)));
            // 
            // codeActivity4
            // 
            this.codeActivity4.Name = "codeActivity4";
            this.codeActivity4.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity13
            // 
            this.setStateActivity13.Name = "setStateActivity13";
            this.setStateActivity13.TargetStateName = "AkceptacjaWniosku";
            // 
            // logToHistoryListActivity27
            // 
            this.logToHistoryListActivity27.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity27.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity27.HistoryDescription = "Wniosek_AkceptacjaWniosku";
            this.logToHistoryListActivity27.HistoryOutcome = "";
            this.logToHistoryListActivity27.Name = "logToHistoryListActivity27";
            this.logToHistoryListActivity27.OtherData = "";
            this.logToHistoryListActivity27.UserId = -1;
            // 
            // logToHistoryListActivity60
            // 
            this.logToHistoryListActivity60.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity60.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind40.Name = "Workflow1";
            activitybind40.Path = "logErrorMessage_HistoryDescription";
            activitybind41.Name = "Workflow1";
            activitybind41.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity60.Name = "logToHistoryListActivity60";
            this.logToHistoryListActivity60.OtherData = "";
            this.logToHistoryListActivity60.UserId = -1;
            this.logToHistoryListActivity60.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind40)));
            this.logToHistoryListActivity60.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind41)));
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity8
            // 
            this.setStateActivity8.Name = "setStateActivity8";
            this.setStateActivity8.TargetStateName = "AkceptacjaOferty";
            // 
            // logToHistoryListActivity37
            // 
            this.logToHistoryListActivity37.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity37.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity37.HistoryDescription = "KorektaOferty_AkceptacjaOferty";
            this.logToHistoryListActivity37.HistoryOutcome = "";
            this.logToHistoryListActivity37.Name = "logToHistoryListActivity37";
            this.logToHistoryListActivity37.OtherData = "";
            this.logToHistoryListActivity37.UserId = -1;
            // 
            // logErrorMessage
            // 
            this.logErrorMessage.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logErrorMessage.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind42.Name = "Workflow1";
            activitybind42.Path = "logErrorMessage_HistoryDescription";
            activitybind43.Name = "Workflow1";
            activitybind43.Path = "logErrorMessage_HistoryOutcome";
            this.logErrorMessage.Name = "logErrorMessage";
            this.logErrorMessage.OtherData = "";
            this.logErrorMessage.UserId = -1;
            this.logErrorMessage.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind42)));
            this.logErrorMessage.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind43)));
            // 
            // ErrorHandler
            // 
            this.ErrorHandler.Name = "ErrorHandler";
            this.ErrorHandler.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity7
            // 
            this.setStateActivity7.Name = "setStateActivity7";
            this.setStateActivity7.TargetStateName = "Telemarketing";
            // 
            // StatusOferta_Telefon
            // 
            this.StatusOferta_Telefon.Name = "StatusOferta_Telefon";
            this.StatusOferta_Telefon.ExecuteCode += new System.EventHandler(this.StatusOferta_Telefon_ExecuteCode);
            // 
            // logToHistoryListActivity24
            // 
            this.logToHistoryListActivity24.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity24.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity24.HistoryDescription = "AkceptacjaOferty_Telemarketing1";
            this.logToHistoryListActivity24.HistoryOutcome = "";
            this.logToHistoryListActivity24.Name = "logToHistoryListActivity24";
            this.logToHistoryListActivity24.OtherData = "";
            this.logToHistoryListActivity24.UserId = -1;
            // 
            // setStateActivity6
            // 
            this.setStateActivity6.Name = "setStateActivity6";
            this.setStateActivity6.TargetStateName = "KorektaOferty";
            // 
            // logToHistoryListActivity23
            // 
            this.logToHistoryListActivity23.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity23.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity23.HistoryDescription = "AkceptacjaOferty_KorektaOferty";
            this.logToHistoryListActivity23.HistoryOutcome = "";
            this.logToHistoryListActivity23.Name = "logToHistoryListActivity23";
            this.logToHistoryListActivity23.OtherData = "";
            this.logToHistoryListActivity23.UserId = -1;
            // 
            // setStateActivity12
            // 
            this.setStateActivity12.Name = "setStateActivity12";
            this.setStateActivity12.TargetStateName = "Odrzucenie";
            // 
            // StatusOferta_Stracony
            // 
            this.StatusOferta_Stracony.Name = "StatusOferta_Stracony";
            this.StatusOferta_Stracony.ExecuteCode += new System.EventHandler(this.StatusOferta_Stracony_ExecuteCode);
            // 
            // Komunikat_OfertaNiezaakceptowana
            // 
            this.Komunikat_OfertaNiezaakceptowana.Enabled = false;
            this.Komunikat_OfertaNiezaakceptowana.Name = "Komunikat_OfertaNiezaakceptowana";
            this.Komunikat_OfertaNiezaakceptowana.ExecuteCode += new System.EventHandler(this.Komunikat_OfertaNiezaakceptowana_ExecuteCode);
            // 
            // logToHistoryListActivity22
            // 
            this.logToHistoryListActivity22.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity22.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity22.HistoryDescription = "AkceptacjaOferty_Odrzucenie";
            this.logToHistoryListActivity22.HistoryOutcome = "";
            this.logToHistoryListActivity22.Name = "logToHistoryListActivity22";
            this.logToHistoryListActivity22.OtherData = "";
            this.logToHistoryListActivity22.UserId = -1;
            // 
            // setStateActivity11
            // 
            this.setStateActivity11.Name = "setStateActivity11";
            this.setStateActivity11.TargetStateName = "Wniosek";
            // 
            // StatusOferta_Wniosek
            // 
            this.StatusOferta_Wniosek.Name = "StatusOferta_Wniosek";
            this.StatusOferta_Wniosek.ExecuteCode += new System.EventHandler(this.StatusOferta_Wniosek_ExecuteCode);
            // 
            // ifElseActivity2
            // 
            this.ifElseActivity2.Activities.Add(this.AkceptacjaOferty_MailSendAllowed);
            this.ifElseActivity2.Name = "ifElseActivity2";
            // 
            // Komunikat_AkceptacjaOferty
            // 
            this.Komunikat_AkceptacjaOferty.Enabled = false;
            this.Komunikat_AkceptacjaOferty.Name = "Komunikat_AkceptacjaOferty";
            this.Komunikat_AkceptacjaOferty.ExecuteCode += new System.EventHandler(this.Komunikat_AkceptacjaOferty_ExecuteCode);
            // 
            // logToHistoryListActivity21
            // 
            this.logToHistoryListActivity21.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity21.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity21.HistoryDescription = "AkceptacjaOferty_Wniosek";
            this.logToHistoryListActivity21.HistoryOutcome = "";
            this.logToHistoryListActivity21.Name = "logToHistoryListActivity21";
            this.logToHistoryListActivity21.OtherData = "";
            this.logToHistoryListActivity21.UserId = -1;
            // 
            // logToHistoryListActivity17
            // 
            this.logToHistoryListActivity17.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity17.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity17.HistoryDescription = "Wiadomość wysłana";
            this.logToHistoryListActivity17.HistoryOutcome = "";
            this.logToHistoryListActivity17.Name = "logToHistoryListActivity17";
            this.logToHistoryListActivity17.OtherData = "";
            this.logToHistoryListActivity17.UserId = -1;
            // 
            // sendEmail_Stracony
            // 
            activitybind44.Name = "Workflow1";
            activitybind44.Path = "Mail_BCC";
            activitybind45.Name = "Workflow1";
            activitybind45.Path = "Mail_Body";
            activitybind46.Name = "Workflow1";
            activitybind46.Path = "Mail_CC";
            correlationtoken5.Name = "myWorkflowToken";
            correlationtoken5.OwnerActivityName = "Workflow1";
            this.sendEmail_Stracony.CorrelationToken = correlationtoken5;
            activitybind47.Name = "Workflow1";
            activitybind47.Path = "Mail_From";
            this.sendEmail_Stracony.Headers = null;
            this.sendEmail_Stracony.IncludeStatus = false;
            this.sendEmail_Stracony.Name = "sendEmail_Stracony";
            activitybind48.Name = "Workflow1";
            activitybind48.Path = "Mail_Subject";
            activitybind49.Name = "Workflow1";
            activitybind49.Path = "Mail_To";
            this.sendEmail_Stracony.MethodInvoking += new System.EventHandler(this.sendEmail_Stracony_MethodInvoking);
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind49)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind48)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind45)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind44)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind46)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind47)));
            // 
            // logToHistoryListActivity59
            // 
            this.logToHistoryListActivity59.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity59.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind50.Name = "Workflow1";
            activitybind50.Path = "logErrorMessage_HistoryDescription";
            activitybind51.Name = "Workflow1";
            activitybind51.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity59.Name = "logToHistoryListActivity59";
            this.logToHistoryListActivity59.OtherData = "";
            this.logToHistoryListActivity59.UserId = -1;
            this.logToHistoryListActivity59.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind50)));
            this.logToHistoryListActivity59.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind51)));
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity5
            // 
            this.setStateActivity5.Name = "setStateActivity5";
            this.setStateActivity5.TargetStateName = "AkceptacjaOferty";
            // 
            // logToHistoryListActivity58
            // 
            this.logToHistoryListActivity58.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity58.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind52.Name = "Workflow1";
            activitybind52.Path = "logErrorMessage_HistoryDescription";
            activitybind53.Name = "Workflow1";
            activitybind53.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity58.Name = "logToHistoryListActivity58";
            this.logToHistoryListActivity58.OtherData = "";
            this.logToHistoryListActivity58.UserId = -1;
            this.logToHistoryListActivity58.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind52)));
            this.logToHistoryListActivity58.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind53)));
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity10
            // 
            this.setStateActivity10.Name = "setStateActivity10";
            this.setStateActivity10.TargetStateName = "Odrzucenie";
            // 
            // StatusTelefon_Stracony
            // 
            this.StatusTelefon_Stracony.Name = "StatusTelefon_Stracony";
            this.StatusTelefon_Stracony.ExecuteCode += new System.EventHandler(this.StatusTelefon_Stracony_ExecuteCode);
            // 
            // logToHistoryListActivity34
            // 
            this.logToHistoryListActivity34.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity34.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity34.HistoryDescription = "Telemarketing_Odrzucenie";
            this.logToHistoryListActivity34.HistoryOutcome = "";
            this.logToHistoryListActivity34.Name = "logToHistoryListActivity34";
            this.logToHistoryListActivity34.OtherData = "";
            this.logToHistoryListActivity34.UserId = -1;
            // 
            // setStateActivity9
            // 
            this.setStateActivity9.Name = "setStateActivity9";
            this.setStateActivity9.TargetStateName = "Oferta";
            // 
            // StatusTelefon_Oferta
            // 
            this.StatusTelefon_Oferta.Name = "StatusTelefon_Oferta";
            this.StatusTelefon_Oferta.ExecuteCode += new System.EventHandler(this.StatusTelefon_Oferta_ExecuteCode);
            // 
            // logToHistoryListActivity33
            // 
            this.logToHistoryListActivity33.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity33.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity33.HistoryDescription = "Telemarketing_Oferta";
            this.logToHistoryListActivity33.HistoryOutcome = "";
            this.logToHistoryListActivity33.Name = "logToHistoryListActivity33";
            this.logToHistoryListActivity33.OtherData = "";
            this.logToHistoryListActivity33.UserId = -1;
            // 
            // logERROR_WefyfikacjaInit
            // 
            this.logERROR_WefyfikacjaInit.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logERROR_WefyfikacjaInit.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logERROR_WefyfikacjaInit.HistoryDescription = "WeryfikacjaInit";
            this.logERROR_WefyfikacjaInit.HistoryOutcome = "ERR";
            this.logERROR_WefyfikacjaInit.Name = "logERROR_WefyfikacjaInit";
            this.logERROR_WefyfikacjaInit.OtherData = "";
            this.logERROR_WefyfikacjaInit.UserId = -1;
            // 
            // logToHistoryListActivity57
            // 
            this.logToHistoryListActivity57.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity57.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind54.Name = "Workflow1";
            activitybind54.Path = "logErrorMessage_HistoryDescription";
            activitybind55.Name = "Workflow1";
            activitybind55.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity57.Name = "logToHistoryListActivity57";
            this.logToHistoryListActivity57.OtherData = "";
            this.logToHistoryListActivity57.UserId = -1;
            this.logToHistoryListActivity57.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind55)));
            this.logToHistoryListActivity57.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind54)));
            // 
            // ErrorHandler_Weryfikacja
            // 
            this.ErrorHandler_Weryfikacja.Name = "ErrorHandler_Weryfikacja";
            this.ErrorHandler_Weryfikacja.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "Odrzucenie";
            // 
            // StatusRozmowa_Stracony
            // 
            this.StatusRozmowa_Stracony.Name = "StatusRozmowa_Stracony";
            this.StatusRozmowa_Stracony.ExecuteCode += new System.EventHandler(this.StatusRozmowa_Stracony_ExecuteCode);
            // 
            // logToHistoryListActivity31
            // 
            this.logToHistoryListActivity31.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity31.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity31.HistoryDescription = "Weryfikacja_Odrzucenie";
            this.logToHistoryListActivity31.HistoryOutcome = "";
            this.logToHistoryListActivity31.Name = "logToHistoryListActivity31";
            this.logToHistoryListActivity31.OtherData = "";
            this.logToHistoryListActivity31.UserId = -1;
            // 
            // setStateActivity4
            // 
            this.setStateActivity4.Name = "setStateActivity4";
            this.setStateActivity4.TargetStateName = "Telemarketing";
            // 
            // StatusRozmowa_Telefon
            // 
            this.StatusRozmowa_Telefon.Name = "StatusRozmowa_Telefon";
            this.StatusRozmowa_Telefon.ExecuteCode += new System.EventHandler(this.StatusRozmowa_Telefon_ExecuteCode);
            // 
            // logToHistoryListActivity30
            // 
            this.logToHistoryListActivity30.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity30.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity30.HistoryDescription = "Weryfikacja_Telemarketing";
            this.logToHistoryListActivity30.HistoryOutcome = "";
            this.logToHistoryListActivity30.Name = "logToHistoryListActivity30";
            this.logToHistoryListActivity30.OtherData = "";
            this.logToHistoryListActivity30.UserId = -1;
            // 
            // setStateActivity3
            // 
            this.setStateActivity3.Name = "setStateActivity3";
            this.setStateActivity3.TargetStateName = "Oferta";
            // 
            // StatusRozmowa_Oferta
            // 
            this.StatusRozmowa_Oferta.Name = "StatusRozmowa_Oferta";
            this.StatusRozmowa_Oferta.ExecuteCode += new System.EventHandler(this.StatusRozmowa_Oferta_ExecuteCode);
            // 
            // logToHistoryListActivity29
            // 
            this.logToHistoryListActivity29.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity29.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity29.HistoryDescription = "Weryfikacja_Oferta";
            this.logToHistoryListActivity29.HistoryOutcome = "";
            this.logToHistoryListActivity29.Name = "logToHistoryListActivity29";
            this.logToHistoryListActivity29.OtherData = "";
            this.logToHistoryListActivity29.UserId = -1;
            // 
            // logERROR_NavigatorInit
            // 
            this.logERROR_NavigatorInit.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logERROR_NavigatorInit.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logERROR_NavigatorInit.HistoryDescription = "NavigatorInit";
            this.logERROR_NavigatorInit.HistoryOutcome = "ERR";
            this.logERROR_NavigatorInit.Name = "logERROR_NavigatorInit";
            this.logERROR_NavigatorInit.OtherData = "";
            this.logERROR_NavigatorInit.UserId = -1;
            // 
            // Navigator_Routing
            // 
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Telefon);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Oferta);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Wniosek);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Umowa);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Uruchomiony);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Stracony);
            this.Navigator_Routing.Activities.Add(this.faultHandlersActivity7);
            this.Navigator_Routing.Activities.Add(this.StatusLeadu_Rozliczenie);
            this.Navigator_Routing.Activities.Add(this.Status_Lead_Else);
            this.Navigator_Routing.Name = "Navigator_Routing";
            // 
            // E
            // 
            this.E.Activities.Add(this.ifWeryfikacja);
            this.E.Activities.Add(this.ifTelemarketing);
            this.E.Activities.Add(this.ifOferta);
            this.E.Activities.Add(this.ifOdrzucenie);
            this.E.Activities.Add(this.ifAkceptacjaOferty);
            this.E.Activities.Add(this.ifKorektaOferty);
            this.E.Activities.Add(this.ifWniosek);
            this.E.Activities.Add(this.ifAkceptacjaWniosku);
            this.E.Activities.Add(this.ifKorektaWniosku);
            this.E.Activities.Add(this.ifUmowa);
            this.E.Activities.Add(this.ifAkceptacjaUmowy);
            this.E.Activities.Add(this.ifUruchomienie);
            this.E.Activities.Add(this.ifDokumentacja);
            this.E.Activities.Add(this.ifRozliczenie);
            this.E.Activities.Add(this.Else2);
            this.E.Name = "E";
            // 
            // faultHandlerActivity2
            // 
            this.faultHandlerActivity2.Activities.Add(this.logToHistoryListActivity4);
            this.faultHandlerActivity2.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity2.Name = "faultHandlerActivity2";
            // 
            // faultHandlerActivity15
            // 
            this.faultHandlerActivity15.Activities.Add(this.codeActivity10);
            this.faultHandlerActivity15.Activities.Add(this.logToHistoryListActivity67);
            this.faultHandlerActivity15.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity15.Name = "faultHandlerActivity15";
            // 
            // Dokumentacja_Rozliczenie
            // 
            this.Dokumentacja_Rozliczenie.Activities.Add(this.logToHistoryListActivity54);
            this.Dokumentacja_Rozliczenie.Activities.Add(this.setStateActivity21);
            codecondition27.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsDokumentacja_Rozliczenie);
            this.Dokumentacja_Rozliczenie.Condition = codecondition27;
            this.Dokumentacja_Rozliczenie.Name = "Dokumentacja_Rozliczenie";
            // 
            // faultHandlerActivity14
            // 
            this.faultHandlerActivity14.Activities.Add(this.codeActivity9);
            this.faultHandlerActivity14.Activities.Add(this.logToHistoryListActivity66);
            this.faultHandlerActivity14.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity14.Name = "faultHandlerActivity14";
            // 
            // Uruchomienie_Dokumentacja
            // 
            this.Uruchomienie_Dokumentacja.Activities.Add(this.logToHistoryListActivity51);
            this.Uruchomienie_Dokumentacja.Activities.Add(this.ifElseActivity10);
            this.Uruchomienie_Dokumentacja.Activities.Add(this.setStateActivity22);
            codecondition28.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsUruchomienie_Dokumentacja);
            this.Uruchomienie_Dokumentacja.Condition = codecondition28;
            this.Uruchomienie_Dokumentacja.Name = "Uruchomienie_Dokumentacja";
            // 
            // faultHandlerActivity13
            // 
            this.faultHandlerActivity13.Activities.Add(this.codeActivity8);
            this.faultHandlerActivity13.Activities.Add(this.logToHistoryListActivity65);
            this.faultHandlerActivity13.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity13.Name = "faultHandlerActivity13";
            // 
            // AkceptacjaUmowy_Telemarketing
            // 
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.logToHistoryListActivity49);
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.Komunikat_UmowaNiezaakceptowana);
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.StatusUmowa_Telefon);
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.setStateActivity18);
            codecondition29.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_Telemarketing);
            this.AkceptacjaUmowy_Telemarketing.Condition = codecondition29;
            this.AkceptacjaUmowy_Telemarketing.Name = "AkceptacjaUmowy_Telemarketing";
            // 
            // AkceptacjaUmowy_Odrzucenie
            // 
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.logToHistoryListActivity48);
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.Komunikat_UmowaStracona);
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.StatusUmowa_Stracony);
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.setStateActivity24);
            codecondition30.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_Odrzucenie);
            this.AkceptacjaUmowy_Odrzucenie.Condition = codecondition30;
            this.AkceptacjaUmowy_Odrzucenie.Name = "AkceptacjaUmowy_Odrzucenie";
            // 
            // AkceptacjaUmowy_Uruchomienie
            // 
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.logToHistoryListActivity47);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.Komunikat_UmowaUruchomiona);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.ifElseActivity4);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.StatusUmowa_Uruchomienie);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.setStateActivity20);
            codecondition31.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_Uruchomienie);
            this.AkceptacjaUmowy_Uruchomienie.Condition = codecondition31;
            this.AkceptacjaUmowy_Uruchomienie.Name = "AkceptacjaUmowy_Uruchomienie";
            // 
            // faultHandlerActivity12
            // 
            this.faultHandlerActivity12.Activities.Add(this.codeActivity7);
            this.faultHandlerActivity12.Activities.Add(this.logToHistoryListActivity64);
            this.faultHandlerActivity12.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity12.Name = "faultHandlerActivity12";
            // 
            // Umowa_AkceptacjaUmowy
            // 
            this.Umowa_AkceptacjaUmowy.Activities.Add(this.logToHistoryListActivity45);
            this.Umowa_AkceptacjaUmowy.Activities.Add(this.setStateActivity19);
            codecondition32.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsUmowa_AkceptacjaUmowy);
            this.Umowa_AkceptacjaUmowy.Condition = codecondition32;
            this.Umowa_AkceptacjaUmowy.Name = "Umowa_AkceptacjaUmowy";
            // 
            // faultHandlerActivity11
            // 
            this.faultHandlerActivity11.Activities.Add(this.codeActivity6);
            this.faultHandlerActivity11.Activities.Add(this.logToHistoryListActivity63);
            this.faultHandlerActivity11.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity11.Name = "faultHandlerActivity11";
            // 
            // KorektaWniosku_AkceptacjaWniosku
            // 
            this.KorektaWniosku_AkceptacjaWniosku.Activities.Add(this.logToHistoryListActivity43);
            this.KorektaWniosku_AkceptacjaWniosku.Activities.Add(this.setStateActivity17);
            codecondition33.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWniosek_AkceptacjaWniosku);
            this.KorektaWniosku_AkceptacjaWniosku.Condition = codecondition33;
            this.KorektaWniosku_AkceptacjaWniosku.Name = "KorektaWniosku_AkceptacjaWniosku";
            // 
            // faultHandlerActivity10
            // 
            this.faultHandlerActivity10.Activities.Add(this.codeActivity5);
            this.faultHandlerActivity10.Activities.Add(this.logToHistoryListActivity62);
            this.faultHandlerActivity10.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity10.Name = "faultHandlerActivity10";
            // 
            // AkceptacjaWniosku_Odrzucenie
            // 
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.logToHistoryListActivity41);
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.Komunikat_WniosekOdrzucony);
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.StatusWniosek_Stracony);
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.setStateActivity16);
            codecondition34.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_Odrzucenie);
            this.AkceptacjaWniosku_Odrzucenie.Condition = codecondition34;
            this.AkceptacjaWniosku_Odrzucenie.Name = "AkceptacjaWniosku_Odrzucenie";
            // 
            // AkceptacjaWniosku_KorektaWniosku
            // 
            this.AkceptacjaWniosku_KorektaWniosku.Activities.Add(this.logToHistoryListActivity40);
            this.AkceptacjaWniosku_KorektaWniosku.Activities.Add(this.setStateActivity15);
            codecondition35.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_KorektaWniosku);
            this.AkceptacjaWniosku_KorektaWniosku.Condition = codecondition35;
            this.AkceptacjaWniosku_KorektaWniosku.Name = "AkceptacjaWniosku_KorektaWniosku";
            // 
            // AkceptacjaWniosku_Umowa
            // 
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.logToHistoryListActivity39);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.Komunikat_AkceptacjaWniosku);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.ifElseActivity3);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.StatusWniosek_Umowa);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.setStateActivity14);
            codecondition36.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_Umowa);
            this.AkceptacjaWniosku_Umowa.Condition = codecondition36;
            this.AkceptacjaWniosku_Umowa.Name = "AkceptacjaWniosku_Umowa";
            // 
            // faultHandlerActivity9
            // 
            this.faultHandlerActivity9.Activities.Add(this.codeActivity4);
            this.faultHandlerActivity9.Activities.Add(this.logToHistoryListActivity61);
            this.faultHandlerActivity9.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity9.Name = "faultHandlerActivity9";
            // 
            // Wniosek_AkceptacjaWniosku
            // 
            this.Wniosek_AkceptacjaWniosku.Activities.Add(this.logToHistoryListActivity27);
            this.Wniosek_AkceptacjaWniosku.Activities.Add(this.setStateActivity13);
            codecondition37.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWniosek_AkceptacjaWniosku);
            this.Wniosek_AkceptacjaWniosku.Condition = codecondition37;
            this.Wniosek_AkceptacjaWniosku.Name = "Wniosek_AkceptacjaWniosku";
            // 
            // faultHandlerActivity8
            // 
            this.faultHandlerActivity8.Activities.Add(this.codeActivity3);
            this.faultHandlerActivity8.Activities.Add(this.logToHistoryListActivity60);
            this.faultHandlerActivity8.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity8.Name = "faultHandlerActivity8";
            // 
            // KorektaOferty_AkceptacjaOferty
            // 
            this.KorektaOferty_AkceptacjaOferty.Activities.Add(this.logToHistoryListActivity37);
            this.KorektaOferty_AkceptacjaOferty.Activities.Add(this.setStateActivity8);
            codecondition38.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.KorektaOferty_AkceptacjaOferty.Condition = codecondition38;
            this.KorektaOferty_AkceptacjaOferty.Name = "KorektaOferty_AkceptacjaOferty";
            // 
            // faultHandlerActivity1
            // 
            this.faultHandlerActivity1.Activities.Add(this.ErrorHandler);
            this.faultHandlerActivity1.Activities.Add(this.logErrorMessage);
            this.faultHandlerActivity1.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity1.Name = "faultHandlerActivity1";
            // 
            // AkceptacjaOferty_Telemarketing1
            // 
            this.AkceptacjaOferty_Telemarketing1.Activities.Add(this.logToHistoryListActivity24);
            this.AkceptacjaOferty_Telemarketing1.Activities.Add(this.StatusOferta_Telefon);
            this.AkceptacjaOferty_Telemarketing1.Activities.Add(this.setStateActivity7);
            codecondition39.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_Telemarketing);
            this.AkceptacjaOferty_Telemarketing1.Condition = codecondition39;
            this.AkceptacjaOferty_Telemarketing1.Name = "AkceptacjaOferty_Telemarketing1";
            // 
            // AkceptacjaOferty_KorektaOferty
            // 
            this.AkceptacjaOferty_KorektaOferty.Activities.Add(this.logToHistoryListActivity23);
            this.AkceptacjaOferty_KorektaOferty.Activities.Add(this.setStateActivity6);
            codecondition40.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_KorektaOferty);
            this.AkceptacjaOferty_KorektaOferty.Condition = codecondition40;
            this.AkceptacjaOferty_KorektaOferty.Name = "AkceptacjaOferty_KorektaOferty";
            // 
            // AkceptacjaOferty_Odrzucenie
            // 
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.logToHistoryListActivity22);
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.Komunikat_OfertaNiezaakceptowana);
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.StatusOferta_Stracony);
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.setStateActivity12);
            codecondition41.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_Odrzucenie);
            this.AkceptacjaOferty_Odrzucenie.Condition = codecondition41;
            this.AkceptacjaOferty_Odrzucenie.Name = "AkceptacjaOferty_Odrzucenie";
            // 
            // AkceptacjaOferty_Wniosek
            // 
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.logToHistoryListActivity21);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.Komunikat_AkceptacjaOferty);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.ifElseActivity2);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.StatusOferta_Wniosek);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.setStateActivity11);
            codecondition42.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_Wniosek);
            this.AkceptacjaOferty_Wniosek.Condition = codecondition42;
            this.AkceptacjaOferty_Wniosek.Name = "AkceptacjaOferty_Wniosek";
            // 
            // Odrzucenie_MailSendAllowed
            // 
            this.Odrzucenie_MailSendAllowed.Activities.Add(this.sendEmail_Stracony);
            this.Odrzucenie_MailSendAllowed.Activities.Add(this.logToHistoryListActivity17);
            codecondition43.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOdrzucenie_MailSendAllowed);
            this.Odrzucenie_MailSendAllowed.Condition = codecondition43;
            this.Odrzucenie_MailSendAllowed.Name = "Odrzucenie_MailSendAllowed";
            // 
            // faultHandlerActivity7
            // 
            this.faultHandlerActivity7.Activities.Add(this.codeActivity2);
            this.faultHandlerActivity7.Activities.Add(this.logToHistoryListActivity59);
            this.faultHandlerActivity7.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity7.Name = "faultHandlerActivity7";
            // 
            // Oferta_AkceptacjaOferty
            // 
            this.Oferta_AkceptacjaOferty.Activities.Add(this.setStateActivity5);
            codecondition44.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.Oferta_AkceptacjaOferty.Condition = codecondition44;
            this.Oferta_AkceptacjaOferty.Name = "Oferta_AkceptacjaOferty";
            // 
            // faultHandlerActivity6
            // 
            this.faultHandlerActivity6.Activities.Add(this.codeActivity1);
            this.faultHandlerActivity6.Activities.Add(this.logToHistoryListActivity58);
            this.faultHandlerActivity6.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity6.Name = "faultHandlerActivity6";
            // 
            // Telemarketing_Odrzucenie
            // 
            this.Telemarketing_Odrzucenie.Activities.Add(this.logToHistoryListActivity34);
            this.Telemarketing_Odrzucenie.Activities.Add(this.StatusTelefon_Stracony);
            this.Telemarketing_Odrzucenie.Activities.Add(this.setStateActivity10);
            codecondition45.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Odrzucenie);
            this.Telemarketing_Odrzucenie.Condition = codecondition45;
            this.Telemarketing_Odrzucenie.Name = "Telemarketing_Odrzucenie";
            // 
            // Telemarketing_Oferta
            // 
            this.Telemarketing_Oferta.Activities.Add(this.logToHistoryListActivity33);
            this.Telemarketing_Oferta.Activities.Add(this.StatusTelefon_Oferta);
            this.Telemarketing_Oferta.Activities.Add(this.setStateActivity9);
            codecondition46.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Oferta);
            this.Telemarketing_Oferta.Condition = codecondition46;
            this.Telemarketing_Oferta.Name = "Telemarketing_Oferta";
            // 
            // faultHandlerActivity4
            // 
            this.faultHandlerActivity4.Activities.Add(this.logERROR_WefyfikacjaInit);
            this.faultHandlerActivity4.Enabled = false;
            this.faultHandlerActivity4.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity4.Name = "faultHandlerActivity4";
            // 
            // faultHandlerActivity5
            // 
            this.faultHandlerActivity5.Activities.Add(this.ErrorHandler_Weryfikacja);
            this.faultHandlerActivity5.Activities.Add(this.logToHistoryListActivity57);
            this.faultHandlerActivity5.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity5.Name = "faultHandlerActivity5";
            // 
            // faultHandlersActivity6
            // 
            this.faultHandlersActivity6.Name = "faultHandlersActivity6";
            // 
            // Weryfikacja_Odrzucenie
            // 
            this.Weryfikacja_Odrzucenie.Activities.Add(this.logToHistoryListActivity31);
            this.Weryfikacja_Odrzucenie.Activities.Add(this.StatusRozmowa_Stracony);
            this.Weryfikacja_Odrzucenie.Activities.Add(this.setStateActivity2);
            codecondition47.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Odrzucenie);
            this.Weryfikacja_Odrzucenie.Condition = codecondition47;
            this.Weryfikacja_Odrzucenie.Name = "Weryfikacja_Odrzucenie";
            // 
            // Weryfikacja_Telemarketing
            // 
            this.Weryfikacja_Telemarketing.Activities.Add(this.logToHistoryListActivity30);
            this.Weryfikacja_Telemarketing.Activities.Add(this.StatusRozmowa_Telefon);
            this.Weryfikacja_Telemarketing.Activities.Add(this.setStateActivity4);
            codecondition48.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Telemarketing);
            this.Weryfikacja_Telemarketing.Condition = codecondition48;
            this.Weryfikacja_Telemarketing.Name = "Weryfikacja_Telemarketing";
            // 
            // Weryfikacja_Oferta
            // 
            this.Weryfikacja_Oferta.Activities.Add(this.logToHistoryListActivity29);
            this.Weryfikacja_Oferta.Activities.Add(this.StatusRozmowa_Oferta);
            this.Weryfikacja_Oferta.Activities.Add(this.setStateActivity3);
            codecondition49.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Oferta);
            this.Weryfikacja_Oferta.Condition = codecondition49;
            this.Weryfikacja_Oferta.Name = "Weryfikacja_Oferta";
            // 
            // faultHandlerActivity3
            // 
            this.faultHandlerActivity3.Activities.Add(this.logERROR_NavigatorInit);
            this.faultHandlerActivity3.Enabled = false;
            this.faultHandlerActivity3.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity3.Name = "faultHandlerActivity3";
            // 
            // Else
            // 
            this.Else.Activities.Add(this.Navigator_Routing);
            this.Else.Name = "Else";
            // 
            // ifEtapNotNull
            // 
            this.ifEtapNotNull.Activities.Add(this.E);
            codecondition50.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isEtapNotNull);
            this.ifEtapNotNull.Condition = codecondition50;
            this.ifEtapNotNull.Name = "ifEtapNotNull";
            // 
            // faultHandlersActivity2
            // 
            this.faultHandlersActivity2.Activities.Add(this.faultHandlerActivity2);
            this.faultHandlersActivity2.Name = "faultHandlersActivity2";
            // 
            // setStateActivity25
            // 
            this.setStateActivity25.Name = "setStateActivity25";
            this.setStateActivity25.TargetStateName = "End";
            // 
            // logToHistoryListActivity3
            // 
            this.logToHistoryListActivity3.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity3.Enabled = false;
            this.logToHistoryListActivity3.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind56.Name = "Workflow1";
            activitybind56.Path = "logRozliczenie_DodajDoRozliczen";
            this.logToHistoryListActivity3.HistoryOutcome = "";
            this.logToHistoryListActivity3.Name = "logToHistoryListActivity3";
            this.logToHistoryListActivity3.OtherData = "";
            this.logToHistoryListActivity3.UserId = -1;
            this.logToHistoryListActivity3.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind56)));
            // 
            // nRozliczenie_DodajDoRozliczen
            // 
            this.nRozliczenie_DodajDoRozliczen.Name = "nRozliczenie_DodajDoRozliczen";
            this.nRozliczenie_DodajDoRozliczen.ExecuteCode += new System.EventHandler(this.nRozliczenie_DodajDoRozliczen_ExecuteCode);
            // 
            // SetCT_Rozliczenie
            // 
            this.SetCT_Rozliczenie.Name = "SetCT_Rozliczenie";
            this.SetCT_Rozliczenie.ExecuteCode += new System.EventHandler(this.SetCT_Rozliczenie_ExecuteCode);
            // 
            // setState_Rozliczenie
            // 
            correlationtoken6.Name = "myWorkflowToken";
            correlationtoken6.OwnerActivityName = "Workflow1";
            this.setState_Rozliczenie.CorrelationToken = correlationtoken6;
            this.setState_Rozliczenie.Name = "setState_Rozliczenie";
            this.setState_Rozliczenie.State = 26;
            // 
            // logToHistoryListActivity11
            // 
            this.logToHistoryListActivity11.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity11.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity11.HistoryDescription = "::Rozliczenie";
            this.logToHistoryListActivity11.HistoryOutcome = "";
            this.logToHistoryListActivity11.Name = "logToHistoryListActivity11";
            this.logToHistoryListActivity11.OtherData = "";
            this.logToHistoryListActivity11.UserId = -1;
            // 
            // faultHandlersActivity18
            // 
            this.faultHandlersActivity18.Activities.Add(this.faultHandlerActivity15);
            this.faultHandlersActivity18.Name = "faultHandlersActivity18";
            // 
            // ifElseActivity11
            // 
            this.ifElseActivity11.Activities.Add(this.Dokumentacja_Rozliczenie);
            this.ifElseActivity11.Name = "ifElseActivity11";
            // 
            // logToHistoryListActivity53
            // 
            this.logToHistoryListActivity53.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity53.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity53.HistoryDescription = "Dokumentacja_OnChange";
            this.logToHistoryListActivity53.HistoryOutcome = "";
            this.logToHistoryListActivity53.Name = "logToHistoryListActivity53";
            this.logToHistoryListActivity53.OtherData = "";
            this.logToHistoryListActivity53.UserId = -1;
            // 
            // onWorkflowItemChanged11
            // 
            this.onWorkflowItemChanged11.AfterProperties = null;
            this.onWorkflowItemChanged11.BeforeProperties = null;
            correlationtoken7.Name = "wtDokumentacja";
            correlationtoken7.OwnerActivityName = "Dokumentacja";
            this.onWorkflowItemChanged11.CorrelationToken = correlationtoken7;
            this.onWorkflowItemChanged11.Name = "onWorkflowItemChanged11";
            // 
            // initializeWorkflow12
            // 
            this.initializeWorkflow12.CorrelationToken = correlationtoken7;
            this.initializeWorkflow12.Name = "initializeWorkflow12";
            // 
            // setState_Dokumentacja
            // 
            correlationtoken8.Name = "myWorkflowToken";
            correlationtoken8.OwnerActivityName = "Workflow1";
            this.setState_Dokumentacja.CorrelationToken = correlationtoken8;
            this.setState_Dokumentacja.Name = "setState_Dokumentacja";
            this.setState_Dokumentacja.State = 24;
            // 
            // logToHistoryListActivity9
            // 
            this.logToHistoryListActivity9.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity9.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity9.HistoryDescription = "::Dokumentacja";
            this.logToHistoryListActivity9.HistoryOutcome = "";
            this.logToHistoryListActivity9.Name = "logToHistoryListActivity9";
            this.logToHistoryListActivity9.OtherData = "";
            this.logToHistoryListActivity9.UserId = -1;
            // 
            // SetCT_Dokumentacja
            // 
            this.SetCT_Dokumentacja.Name = "SetCT_Dokumentacja";
            this.SetCT_Dokumentacja.ExecuteCode += new System.EventHandler(this.SetCT_Dokumentacja_ExecuteCode);
            // 
            // faultHandlersActivity17
            // 
            this.faultHandlersActivity17.Activities.Add(this.faultHandlerActivity14);
            this.faultHandlersActivity17.Name = "faultHandlersActivity17";
            // 
            // ifElseActivity123
            // 
            this.ifElseActivity123.Activities.Add(this.Uruchomienie_Dokumentacja);
            this.ifElseActivity123.Name = "ifElseActivity123";
            // 
            // logToHistoryListActivity50
            // 
            this.logToHistoryListActivity50.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity50.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity50.HistoryDescription = "Uruchomienie_OnChange";
            this.logToHistoryListActivity50.HistoryOutcome = "";
            this.logToHistoryListActivity50.Name = "logToHistoryListActivity50";
            this.logToHistoryListActivity50.OtherData = "";
            this.logToHistoryListActivity50.UserId = -1;
            // 
            // onWorkflowItemChanged12
            // 
            this.onWorkflowItemChanged12.AfterProperties = null;
            this.onWorkflowItemChanged12.BeforeProperties = null;
            correlationtoken9.Name = "wtUruchomienie";
            correlationtoken9.OwnerActivityName = "Uruchomienie";
            this.onWorkflowItemChanged12.CorrelationToken = correlationtoken9;
            this.onWorkflowItemChanged12.Name = "onWorkflowItemChanged12";
            // 
            // initializeWorkflow11
            // 
            this.initializeWorkflow11.CorrelationToken = correlationtoken9;
            this.initializeWorkflow11.Name = "initializeWorkflow11";
            // 
            // setState_Uruchomienie
            // 
            correlationtoken10.Name = "myWorkflowToken";
            correlationtoken10.OwnerActivityName = "Workflow1";
            this.setState_Uruchomienie.CorrelationToken = correlationtoken10;
            this.setState_Uruchomienie.Name = "setState_Uruchomienie";
            this.setState_Uruchomienie.State = 25;
            // 
            // logToHistoryListActivity10
            // 
            this.logToHistoryListActivity10.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity10.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity10.HistoryDescription = "::Uruchomienie";
            this.logToHistoryListActivity10.HistoryOutcome = "";
            this.logToHistoryListActivity10.Name = "logToHistoryListActivity10";
            this.logToHistoryListActivity10.OtherData = "";
            this.logToHistoryListActivity10.UserId = -1;
            // 
            // SetCT_Uruchomienie
            // 
            this.SetCT_Uruchomienie.Name = "SetCT_Uruchomienie";
            this.SetCT_Uruchomienie.ExecuteCode += new System.EventHandler(this.SetCT_Uruchomienie_ExecuteCode);
            // 
            // faultHandlersActivity16
            // 
            this.faultHandlersActivity16.Activities.Add(this.faultHandlerActivity13);
            this.faultHandlersActivity16.Name = "faultHandlersActivity16";
            // 
            // TestAkceptacjaUmowy
            // 
            this.TestAkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_Uruchomienie);
            this.TestAkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_Odrzucenie);
            this.TestAkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_Telemarketing);
            this.TestAkceptacjaUmowy.Name = "TestAkceptacjaUmowy";
            // 
            // logToHistoryListActivity46
            // 
            this.logToHistoryListActivity46.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity46.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity46.HistoryDescription = "AkceptacjaUmowy_OnChange";
            this.logToHistoryListActivity46.HistoryOutcome = "";
            this.logToHistoryListActivity46.Name = "logToHistoryListActivity46";
            this.logToHistoryListActivity46.OtherData = "";
            this.logToHistoryListActivity46.UserId = -1;
            // 
            // onWorkflowItemChanged10
            // 
            this.onWorkflowItemChanged10.AfterProperties = null;
            this.onWorkflowItemChanged10.BeforeProperties = null;
            correlationtoken11.Name = "wtAkceptacjaUmowy";
            correlationtoken11.OwnerActivityName = "AkceptacjaUmowy";
            this.onWorkflowItemChanged10.CorrelationToken = correlationtoken11;
            this.onWorkflowItemChanged10.Name = "onWorkflowItemChanged10";
            // 
            // initializeWorkflow10
            // 
            this.initializeWorkflow10.CorrelationToken = correlationtoken11;
            this.initializeWorkflow10.Name = "initializeWorkflow10";
            // 
            // setState_AkceptacjaUmowy
            // 
            correlationtoken12.Name = "myWorkflowToken";
            correlationtoken12.OwnerActivityName = "Workflow1";
            this.setState_AkceptacjaUmowy.CorrelationToken = correlationtoken12;
            this.setState_AkceptacjaUmowy.Name = "setState_AkceptacjaUmowy";
            this.setState_AkceptacjaUmowy.State = 28;
            // 
            // logToHistoryListActivity13
            // 
            this.logToHistoryListActivity13.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity13.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity13.HistoryDescription = "::Akceptacja umowy";
            this.logToHistoryListActivity13.HistoryOutcome = "";
            this.logToHistoryListActivity13.Name = "logToHistoryListActivity13";
            this.logToHistoryListActivity13.OtherData = "";
            this.logToHistoryListActivity13.UserId = -1;
            // 
            // SetCT_AkceptacjaUmowy
            // 
            this.SetCT_AkceptacjaUmowy.Name = "SetCT_AkceptacjaUmowy";
            this.SetCT_AkceptacjaUmowy.ExecuteCode += new System.EventHandler(this.SetCT_AkceptacjaUmowy_ExecuteCode);
            // 
            // faultHandlersActivity15
            // 
            this.faultHandlersActivity15.Activities.Add(this.faultHandlerActivity12);
            this.faultHandlersActivity15.Name = "faultHandlersActivity15";
            // 
            // ifElseActivity9
            // 
            this.ifElseActivity9.Activities.Add(this.Umowa_AkceptacjaUmowy);
            this.ifElseActivity9.Name = "ifElseActivity9";
            // 
            // logToHistoryListActivity44
            // 
            this.logToHistoryListActivity44.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity44.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity44.HistoryDescription = "Umowa_OnChange";
            this.logToHistoryListActivity44.HistoryOutcome = "";
            this.logToHistoryListActivity44.Name = "logToHistoryListActivity44";
            this.logToHistoryListActivity44.OtherData = "";
            this.logToHistoryListActivity44.UserId = -1;
            // 
            // onWorkflowItemChanged9
            // 
            this.onWorkflowItemChanged9.AfterProperties = null;
            this.onWorkflowItemChanged9.BeforeProperties = null;
            correlationtoken13.Name = "wtUmowa";
            correlationtoken13.OwnerActivityName = "Umowa";
            this.onWorkflowItemChanged9.CorrelationToken = correlationtoken13;
            this.onWorkflowItemChanged9.Name = "onWorkflowItemChanged9";
            // 
            // initializeWorkflow9
            // 
            this.initializeWorkflow9.CorrelationToken = correlationtoken13;
            this.initializeWorkflow9.Name = "initializeWorkflow9";
            // 
            // setState_Umowa
            // 
            correlationtoken14.Name = "myWorkflowToken";
            correlationtoken14.OwnerActivityName = "Workflow1";
            this.setState_Umowa.CorrelationToken = correlationtoken14;
            this.setState_Umowa.Name = "setState_Umowa";
            this.setState_Umowa.State = 23;
            // 
            // logToHistoryListActivity8
            // 
            this.logToHistoryListActivity8.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity8.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity8.HistoryDescription = "::Umowa";
            this.logToHistoryListActivity8.HistoryOutcome = "";
            this.logToHistoryListActivity8.Name = "logToHistoryListActivity8";
            this.logToHistoryListActivity8.OtherData = "";
            this.logToHistoryListActivity8.UserId = -1;
            // 
            // SetCT_Umowa
            // 
            this.SetCT_Umowa.Name = "SetCT_Umowa";
            this.SetCT_Umowa.ExecuteCode += new System.EventHandler(this.SetCT_Umowa_ExecuteCode);
            // 
            // faultHandlersActivity14
            // 
            this.faultHandlersActivity14.Activities.Add(this.faultHandlerActivity11);
            this.faultHandlersActivity14.Name = "faultHandlersActivity14";
            // 
            // ifElseActivity8
            // 
            this.ifElseActivity8.Activities.Add(this.KorektaWniosku_AkceptacjaWniosku);
            this.ifElseActivity8.Name = "ifElseActivity8";
            // 
            // logToHistoryListActivity42
            // 
            this.logToHistoryListActivity42.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity42.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity42.HistoryDescription = "KorektaWniosku_OnChange";
            this.logToHistoryListActivity42.HistoryOutcome = "";
            this.logToHistoryListActivity42.Name = "logToHistoryListActivity42";
            this.logToHistoryListActivity42.OtherData = "";
            this.logToHistoryListActivity42.UserId = -1;
            // 
            // onWorkflowItemChanged8
            // 
            this.onWorkflowItemChanged8.AfterProperties = null;
            this.onWorkflowItemChanged8.BeforeProperties = null;
            correlationtoken15.Name = "wtKorektaWniosku";
            correlationtoken15.OwnerActivityName = "KorektaWniosku";
            this.onWorkflowItemChanged8.CorrelationToken = correlationtoken15;
            this.onWorkflowItemChanged8.Name = "onWorkflowItemChanged8";
            // 
            // initializeWorkflow8
            // 
            this.initializeWorkflow8.CorrelationToken = correlationtoken15;
            this.initializeWorkflow8.Name = "initializeWorkflow8";
            // 
            // setState_KorektaWniosku
            // 
            correlationtoken16.Name = "myWorkflowToken";
            correlationtoken16.OwnerActivityName = "Workflow1";
            this.setState_KorektaWniosku.CorrelationToken = correlationtoken16;
            this.setState_KorektaWniosku.Name = "setState_KorektaWniosku";
            this.setState_KorektaWniosku.State = 27;
            // 
            // logToHistoryListActivity12
            // 
            this.logToHistoryListActivity12.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity12.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity12.HistoryDescription = "::Korekta wniosku";
            this.logToHistoryListActivity12.HistoryOutcome = "";
            this.logToHistoryListActivity12.Name = "logToHistoryListActivity12";
            this.logToHistoryListActivity12.OtherData = "";
            this.logToHistoryListActivity12.UserId = -1;
            // 
            // SetCT_Wniosek1
            // 
            this.SetCT_Wniosek1.Name = "SetCT_Wniosek1";
            this.SetCT_Wniosek1.ExecuteCode += new System.EventHandler(this.SetCT_Wniosek_ExecuteCode);
            // 
            // faultHandlersActivity13
            // 
            this.faultHandlersActivity13.Activities.Add(this.faultHandlerActivity10);
            this.faultHandlersActivity13.Name = "faultHandlersActivity13";
            // 
            // ifElseActivity7
            // 
            this.ifElseActivity7.Activities.Add(this.AkceptacjaWniosku_Umowa);
            this.ifElseActivity7.Activities.Add(this.AkceptacjaWniosku_KorektaWniosku);
            this.ifElseActivity7.Activities.Add(this.AkceptacjaWniosku_Odrzucenie);
            this.ifElseActivity7.Name = "ifElseActivity7";
            // 
            // logToHistoryListActivity38
            // 
            this.logToHistoryListActivity38.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity38.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity38.HistoryDescription = "AkceptacjaWniosku_OnChange";
            this.logToHistoryListActivity38.HistoryOutcome = "";
            this.logToHistoryListActivity38.Name = "logToHistoryListActivity38";
            this.logToHistoryListActivity38.OtherData = "";
            this.logToHistoryListActivity38.UserId = -1;
            // 
            // onWorkflowItemChanged7
            // 
            this.onWorkflowItemChanged7.AfterProperties = null;
            this.onWorkflowItemChanged7.BeforeProperties = null;
            correlationtoken17.Name = "wtAkceptacjaWniosku";
            correlationtoken17.OwnerActivityName = "AkceptacjaWniosku";
            this.onWorkflowItemChanged7.CorrelationToken = correlationtoken17;
            this.onWorkflowItemChanged7.Name = "onWorkflowItemChanged7";
            // 
            // initializeWorkflow7
            // 
            this.initializeWorkflow7.CorrelationToken = correlationtoken17;
            this.initializeWorkflow7.Name = "initializeWorkflow7";
            // 
            // setState_AkceptacjaWniosku
            // 
            correlationtoken18.Name = "myWorkflowToken";
            correlationtoken18.OwnerActivityName = "Workflow1";
            this.setState_AkceptacjaWniosku.CorrelationToken = correlationtoken18;
            this.setState_AkceptacjaWniosku.Name = "setState_AkceptacjaWniosku";
            this.setState_AkceptacjaWniosku.State = 22;
            // 
            // logToHistoryListActivity7
            // 
            this.logToHistoryListActivity7.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity7.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity7.HistoryDescription = "::Akceptacja wniosku";
            this.logToHistoryListActivity7.HistoryOutcome = "";
            this.logToHistoryListActivity7.Name = "logToHistoryListActivity7";
            this.logToHistoryListActivity7.OtherData = "";
            this.logToHistoryListActivity7.UserId = -1;
            // 
            // SetCT_AkceptacjaWniosku
            // 
            this.SetCT_AkceptacjaWniosku.Name = "SetCT_AkceptacjaWniosku";
            this.SetCT_AkceptacjaWniosku.ExecuteCode += new System.EventHandler(this.SetCT_AkceptacjaWniosku_ExecuteCode);
            // 
            // faultHandlersActivity12
            // 
            this.faultHandlersActivity12.Activities.Add(this.faultHandlerActivity9);
            this.faultHandlersActivity12.Name = "faultHandlersActivity12";
            // 
            // ifElseActivity6
            // 
            this.ifElseActivity6.Activities.Add(this.Wniosek_AkceptacjaWniosku);
            this.ifElseActivity6.Name = "ifElseActivity6";
            // 
            // logToHistoryListActivity26
            // 
            this.logToHistoryListActivity26.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity26.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity26.HistoryDescription = "Wniosek_OnChange";
            this.logToHistoryListActivity26.HistoryOutcome = "";
            this.logToHistoryListActivity26.Name = "logToHistoryListActivity26";
            this.logToHistoryListActivity26.OtherData = "";
            this.logToHistoryListActivity26.UserId = -1;
            // 
            // onWorkflowItemChanged6
            // 
            this.onWorkflowItemChanged6.AfterProperties = null;
            this.onWorkflowItemChanged6.BeforeProperties = null;
            correlationtoken19.Name = "wtWniosek";
            correlationtoken19.OwnerActivityName = "Wniosek";
            this.onWorkflowItemChanged6.CorrelationToken = correlationtoken19;
            this.onWorkflowItemChanged6.Name = "onWorkflowItemChanged6";
            // 
            // codeDodajDoRozliczen
            // 
            this.codeDodajDoRozliczen.Name = "codeDodajDoRozliczen";
            this.codeDodajDoRozliczen.ExecuteCode += new System.EventHandler(this.codeDodajDoRozliczen_ExecuteCode);
            // 
            // initializeWorkflow6
            // 
            this.initializeWorkflow6.CorrelationToken = correlationtoken19;
            this.initializeWorkflow6.Name = "initializeWorkflow6";
            // 
            // setState_Wniosek
            // 
            correlationtoken20.Name = "myWorkflowToken";
            correlationtoken20.OwnerActivityName = "Workflow1";
            this.setState_Wniosek.CorrelationToken = correlationtoken20;
            this.setState_Wniosek.Name = "setState_Wniosek";
            this.setState_Wniosek.State = 21;
            // 
            // logToHistoryListActivity6
            // 
            this.logToHistoryListActivity6.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity6.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity6.HistoryDescription = "::Wniosek";
            this.logToHistoryListActivity6.HistoryOutcome = "";
            this.logToHistoryListActivity6.Name = "logToHistoryListActivity6";
            this.logToHistoryListActivity6.OtherData = "";
            this.logToHistoryListActivity6.UserId = -1;
            // 
            // SetCT_Wniosek
            // 
            this.SetCT_Wniosek.Name = "SetCT_Wniosek";
            this.SetCT_Wniosek.ExecuteCode += new System.EventHandler(this.SetCT_Wniosek_ExecuteCode);
            // 
            // faultHandlersActivity11
            // 
            this.faultHandlersActivity11.Activities.Add(this.faultHandlerActivity8);
            this.faultHandlersActivity11.Name = "faultHandlersActivity11";
            // 
            // ifElseActivity5
            // 
            this.ifElseActivity5.Activities.Add(this.KorektaOferty_AkceptacjaOferty);
            this.ifElseActivity5.Name = "ifElseActivity5";
            // 
            // logToHistoryListActivity36
            // 
            this.logToHistoryListActivity36.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity36.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity36.HistoryDescription = "KorektaOferty_OnChange";
            this.logToHistoryListActivity36.HistoryOutcome = "";
            this.logToHistoryListActivity36.Name = "logToHistoryListActivity36";
            this.logToHistoryListActivity36.OtherData = "";
            this.logToHistoryListActivity36.UserId = -1;
            // 
            // onWorkflowItemChanged5
            // 
            this.onWorkflowItemChanged5.AfterProperties = null;
            this.onWorkflowItemChanged5.BeforeProperties = null;
            correlationtoken21.Name = "wtKorektaOferty";
            correlationtoken21.OwnerActivityName = "KorektaOferty";
            this.onWorkflowItemChanged5.CorrelationToken = correlationtoken21;
            this.onWorkflowItemChanged5.Name = "onWorkflowItemChanged5";
            // 
            // initializeWorkflow5
            // 
            this.initializeWorkflow5.CorrelationToken = correlationtoken21;
            this.initializeWorkflow5.Name = "initializeWorkflow5";
            // 
            // setState_KorektaOferty
            // 
            correlationtoken22.Name = "myWorkflowToken";
            correlationtoken22.OwnerActivityName = "Workflow1";
            this.setState_KorektaOferty.CorrelationToken = correlationtoken22;
            this.setState_KorektaOferty.Name = "setState_KorektaOferty";
            this.setState_KorektaOferty.State = 20;
            // 
            // logKorektaOferty
            // 
            this.logKorektaOferty.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logKorektaOferty.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logKorektaOferty.HistoryDescription = "::Korekta oferty";
            this.logKorektaOferty.HistoryOutcome = "";
            this.logKorektaOferty.Name = "logKorektaOferty";
            this.logKorektaOferty.OtherData = "";
            this.logKorektaOferty.UserId = -1;
            // 
            // SetCT_Oferta1
            // 
            this.SetCT_Oferta1.Name = "SetCT_Oferta1";
            this.SetCT_Oferta1.ExecuteCode += new System.EventHandler(this.SetCT_Oferta_ExecuteCode);
            // 
            // faultHandlersActivity8
            // 
            this.faultHandlersActivity8.Activities.Add(this.faultHandlerActivity1);
            this.faultHandlersActivity8.Name = "faultHandlersActivity8";
            // 
            // AkceptacjaOferty_Telemarketing
            // 
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_Wniosek);
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_Odrzucenie);
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_KorektaOferty);
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_Telemarketing1);
            this.AkceptacjaOferty_Telemarketing.Name = "AkceptacjaOferty_Telemarketing";
            // 
            // logToHistoryListActivity25
            // 
            this.logToHistoryListActivity25.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity25.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity25.HistoryDescription = "AkceptacjaOferty_OnChange";
            this.logToHistoryListActivity25.HistoryOutcome = "";
            this.logToHistoryListActivity25.Name = "logToHistoryListActivity25";
            this.logToHistoryListActivity25.OtherData = "";
            this.logToHistoryListActivity25.UserId = -1;
            // 
            // onWorkflowItemChanged4
            // 
            this.onWorkflowItemChanged4.AfterProperties = null;
            this.onWorkflowItemChanged4.BeforeProperties = null;
            correlationtoken23.Name = "wtAkceptacjaOferty";
            correlationtoken23.OwnerActivityName = "AkceptacjaOferty";
            this.onWorkflowItemChanged4.CorrelationToken = correlationtoken23;
            this.onWorkflowItemChanged4.Name = "onWorkflowItemChanged4";
            // 
            // initializeWorkflow4
            // 
            this.initializeWorkflow4.CorrelationToken = correlationtoken23;
            this.initializeWorkflow4.Name = "initializeWorkflow4";
            // 
            // setState_AkceptacjaOferty
            // 
            correlationtoken24.Name = "myWorkflowToken";
            correlationtoken24.OwnerActivityName = "Workflow1";
            this.setState_AkceptacjaOferty.CorrelationToken = correlationtoken24;
            this.setState_AkceptacjaOferty.Name = "setState_AkceptacjaOferty";
            this.setState_AkceptacjaOferty.State = 19;
            // 
            // logToHistoryListActivity5
            // 
            this.logToHistoryListActivity5.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity5.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity5.HistoryDescription = "::Akceptacja oferty";
            this.logToHistoryListActivity5.HistoryOutcome = "";
            this.logToHistoryListActivity5.Name = "logToHistoryListActivity5";
            this.logToHistoryListActivity5.OtherData = "";
            this.logToHistoryListActivity5.UserId = -1;
            // 
            // SetCT_AkceptacjaOferty
            // 
            this.SetCT_AkceptacjaOferty.Name = "SetCT_AkceptacjaOferty";
            this.SetCT_AkceptacjaOferty.ExecuteCode += new System.EventHandler(this.SetCT_AkceptacjaOferty_ExecuteCode);
            // 
            // setStateActivity26
            // 
            this.setStateActivity26.Name = "setStateActivity26";
            this.setStateActivity26.TargetStateName = "End";
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.Odrzucenie_MailSendAllowed);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // logToHistoryListActivity2
            // 
            this.logToHistoryListActivity2.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity2.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity2.HistoryDescription = "::Odrzucony";
            this.logToHistoryListActivity2.HistoryOutcome = "";
            this.logToHistoryListActivity2.Name = "logToHistoryListActivity2";
            this.logToHistoryListActivity2.OtherData = "";
            this.logToHistoryListActivity2.UserId = -1;
            // 
            // SetCT_Odrzucony
            // 
            this.SetCT_Odrzucony.Name = "SetCT_Odrzucony";
            this.SetCT_Odrzucony.ExecuteCode += new System.EventHandler(this.SetCT_Odrzucony_ExecuteCode);
            // 
            // setState_Odrzucony
            // 
            this.setState_Odrzucony.CorrelationToken = correlationtoken5;
            this.setState_Odrzucony.Name = "setState_Odrzucony";
            this.setState_Odrzucony.State = 16;
            // 
            // faultHandlersActivity10
            // 
            this.faultHandlersActivity10.Activities.Add(this.faultHandlerActivity7);
            this.faultHandlersActivity10.Name = "faultHandlersActivity10";
            // 
            // Oferta_Routing
            // 
            this.Oferta_Routing.Activities.Add(this.Oferta_AkceptacjaOferty);
            this.Oferta_Routing.Name = "Oferta_Routing";
            // 
            // logToHistoryListActivity35
            // 
            this.logToHistoryListActivity35.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity35.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity35.HistoryDescription = "Oferta_OnChange";
            this.logToHistoryListActivity35.HistoryOutcome = "";
            this.logToHistoryListActivity35.Name = "logToHistoryListActivity35";
            this.logToHistoryListActivity35.OtherData = "";
            this.logToHistoryListActivity35.UserId = -1;
            // 
            // onWorkflowItemChanged2
            // 
            this.onWorkflowItemChanged2.AfterProperties = null;
            this.onWorkflowItemChanged2.BeforeProperties = null;
            correlationtoken25.Name = "wtOferta";
            correlationtoken25.OwnerActivityName = "Oferta";
            this.onWorkflowItemChanged2.CorrelationToken = correlationtoken25;
            this.onWorkflowItemChanged2.Name = "onWorkflowItemChanged2";
            // 
            // initializeWorkflow3
            // 
            this.initializeWorkflow3.CorrelationToken = correlationtoken25;
            this.initializeWorkflow3.Name = "initializeWorkflow3";
            // 
            // setState_Oferta
            // 
            correlationtoken26.Name = "myWorkflowToken";
            correlationtoken26.OwnerActivityName = "Workflow1";
            this.setState_Oferta.CorrelationToken = correlationtoken26;
            this.setState_Oferta.Name = "setState_Oferta";
            this.setState_Oferta.State = 18;
            // 
            // logToHistoryListActivity15
            // 
            this.logToHistoryListActivity15.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity15.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity15.HistoryDescription = "::Oferta";
            this.logToHistoryListActivity15.HistoryOutcome = "";
            this.logToHistoryListActivity15.Name = "logToHistoryListActivity15";
            this.logToHistoryListActivity15.OtherData = "";
            this.logToHistoryListActivity15.UserId = -1;
            // 
            // SetCT_Oferta
            // 
            this.SetCT_Oferta.Name = "SetCT_Oferta";
            this.SetCT_Oferta.ExecuteCode += new System.EventHandler(this.SetCT_Oferta_ExecuteCode);
            // 
            // faultHandlersActivity9
            // 
            this.faultHandlersActivity9.Activities.Add(this.faultHandlerActivity6);
            this.faultHandlersActivity9.Name = "faultHandlersActivity9";
            // 
            // Telemarketing_Routing
            // 
            this.Telemarketing_Routing.Activities.Add(this.Telemarketing_Oferta);
            this.Telemarketing_Routing.Activities.Add(this.Telemarketing_Odrzucenie);
            this.Telemarketing_Routing.Name = "Telemarketing_Routing";
            // 
            // logToHistoryListActivity32
            // 
            this.logToHistoryListActivity32.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity32.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity32.HistoryDescription = "Telemarketing_OnChange";
            this.logToHistoryListActivity32.HistoryOutcome = "";
            this.logToHistoryListActivity32.Name = "logToHistoryListActivity32";
            this.logToHistoryListActivity32.OtherData = "";
            this.logToHistoryListActivity32.UserId = -1;
            // 
            // onWorkflowItemChanged3
            // 
            this.onWorkflowItemChanged3.AfterProperties = null;
            this.onWorkflowItemChanged3.BeforeProperties = null;
            correlationtoken27.Name = "wtTelemarketing";
            correlationtoken27.OwnerActivityName = "Telemarketing";
            this.onWorkflowItemChanged3.CorrelationToken = correlationtoken27;
            this.onWorkflowItemChanged3.Name = "onWorkflowItemChanged3";
            // 
            // initializeWorkflow2
            // 
            this.initializeWorkflow2.CorrelationToken = correlationtoken27;
            this.initializeWorkflow2.Name = "initializeWorkflow2";
            this.initializeWorkflow2.MethodInvoking += new System.EventHandler(this.initializeWorkflow2_MethodInvoking);
            // 
            // setState_Telemarketing
            // 
            correlationtoken28.Name = "myWorkflowToken";
            correlationtoken28.OwnerActivityName = "Workflow1";
            this.setState_Telemarketing.CorrelationToken = correlationtoken28;
            this.setState_Telemarketing.Name = "setState_Telemarketing";
            this.setState_Telemarketing.State = 17;
            // 
            // logToHistoryListActivity16
            // 
            this.logToHistoryListActivity16.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity16.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity16.HistoryDescription = "::Telemerketing";
            this.logToHistoryListActivity16.HistoryOutcome = "";
            this.logToHistoryListActivity16.Name = "logToHistoryListActivity16";
            this.logToHistoryListActivity16.OtherData = "";
            this.logToHistoryListActivity16.UserId = -1;
            // 
            // SetCT_Telemarketing
            // 
            this.SetCT_Telemarketing.Name = "SetCT_Telemarketing";
            this.SetCT_Telemarketing.ExecuteCode += new System.EventHandler(this.SetCT_Telemarketing_ExecuteCode);
            // 
            // faultHandlersActivity4
            // 
            this.faultHandlersActivity4.Activities.Add(this.faultHandlerActivity4);
            this.faultHandlersActivity4.Name = "faultHandlersActivity4";
            // 
            // initializeWorkflow1
            // 
            correlationtoken29.Name = "wtWeryfikacja";
            correlationtoken29.OwnerActivityName = "Weryfikacja";
            this.initializeWorkflow1.CorrelationToken = correlationtoken29;
            this.initializeWorkflow1.Name = "initializeWorkflow1";
            // 
            // logToHistoryListActivity14
            // 
            this.logToHistoryListActivity14.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity14.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity14.HistoryDescription = "::Weryfikacja";
            this.logToHistoryListActivity14.HistoryOutcome = "";
            this.logToHistoryListActivity14.Name = "logToHistoryListActivity14";
            this.logToHistoryListActivity14.OtherData = "";
            this.logToHistoryListActivity14.UserId = -1;
            // 
            // setState_Weryfikacja
            // 
            correlationtoken30.Name = "myWorkflowToken";
            correlationtoken30.OwnerActivityName = "Workflow1";
            this.setState_Weryfikacja.CorrelationToken = correlationtoken30;
            this.setState_Weryfikacja.Name = "setState_Weryfikacja";
            this.setState_Weryfikacja.State = 15;
            // 
            // SetCT_Weryfikacja
            // 
            this.SetCT_Weryfikacja.Name = "SetCT_Weryfikacja";
            this.SetCT_Weryfikacja.ExecuteCode += new System.EventHandler(this.SetCT_Weryfikacja_ExecuteCode);
            // 
            // faultHandlersActivity5
            // 
            this.faultHandlersActivity5.Activities.Add(this.faultHandlerActivity5);
            this.faultHandlersActivity5.Name = "faultHandlersActivity5";
            // 
            // Weryfikacja_Routing
            // 
            this.Weryfikacja_Routing.Activities.Add(this.Weryfikacja_Oferta);
            this.Weryfikacja_Routing.Activities.Add(this.Weryfikacja_Telemarketing);
            this.Weryfikacja_Routing.Activities.Add(this.Weryfikacja_Odrzucenie);
            this.Weryfikacja_Routing.Activities.Add(this.faultHandlersActivity6);
            this.Weryfikacja_Routing.Name = "Weryfikacja_Routing";
            // 
            // logToHistoryListActivity28
            // 
            this.logToHistoryListActivity28.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity28.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity28.HistoryDescription = "Weryfikacja_OnChange";
            this.logToHistoryListActivity28.HistoryOutcome = "";
            this.logToHistoryListActivity28.Name = "logToHistoryListActivity28";
            this.logToHistoryListActivity28.OtherData = "";
            this.logToHistoryListActivity28.UserId = -1;
            // 
            // onWorkflowItemChanged13
            // 
            this.onWorkflowItemChanged13.AfterProperties = null;
            this.onWorkflowItemChanged13.BeforeProperties = null;
            this.onWorkflowItemChanged13.CorrelationToken = correlationtoken29;
            this.onWorkflowItemChanged13.Name = "onWorkflowItemChanged13";
            // 
            // faultHandlersActivity3
            // 
            this.faultHandlersActivity3.Activities.Add(this.faultHandlerActivity3);
            this.faultHandlersActivity3.Name = "faultHandlersActivity3";
            // 
            // TestEtap
            // 
            this.TestEtap.Activities.Add(this.ifEtapNotNull);
            this.TestEtap.Activities.Add(this.Else);
            this.TestEtap.Name = "TestEtap";
            // 
            // logRouter
            // 
            this.logRouter.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logRouter.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logRouter.HistoryDescription = "::Router";
            this.logRouter.HistoryOutcome = "";
            this.logRouter.Name = "logRouter";
            this.logRouter.OtherData = "";
            this.logRouter.UserId = -1;
            // 
            // faultHandlersActivity1
            // 
            this.faultHandlersActivity1.Name = "faultHandlersActivity1";
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "Navigator";
            // 
            // StatusLead_Rozmowa
            // 
            this.StatusLead_Rozmowa.Enabled = false;
            this.StatusLead_Rozmowa.Name = "StatusLead_Rozmowa";
            // 
            // codeSetup
            // 
            this.codeSetup.Name = "codeSetup";
            this.codeSetup.ExecuteCode += new System.EventHandler(this.codeSetup_ExecuteCode);
            // 
            // logZainicjowany
            // 
            this.logZainicjowany.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logZainicjowany.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logZainicjowany.HistoryDescription = "::Zainicjowany";
            this.logZainicjowany.HistoryOutcome = "";
            this.logZainicjowany.Name = "logZainicjowany";
            this.logZainicjowany.OtherData = "";
            this.logZainicjowany.UserId = -1;
            // 
            // onWorkflowActivated1
            // 
            correlationtoken31.Name = "myWorkflowToken";
            correlationtoken31.OwnerActivityName = "Workflow1";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken31;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind57.Name = "Workflow1";
            activitybind57.Path = "workflowProperties";
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind57)));
            // 
            // stateInitializationActivity12
            // 
            this.stateInitializationActivity12.Activities.Add(this.logToHistoryListActivity11);
            this.stateInitializationActivity12.Activities.Add(this.setState_Rozliczenie);
            this.stateInitializationActivity12.Activities.Add(this.SetCT_Rozliczenie);
            this.stateInitializationActivity12.Activities.Add(this.nRozliczenie_DodajDoRozliczen);
            this.stateInitializationActivity12.Activities.Add(this.logToHistoryListActivity3);
            this.stateInitializationActivity12.Activities.Add(this.setStateActivity25);
            this.stateInitializationActivity12.Activities.Add(this.faultHandlersActivity2);
            this.stateInitializationActivity12.Name = "stateInitializationActivity12";
            // 
            // Dokumentacja_OnChange
            // 
            this.Dokumentacja_OnChange.Activities.Add(this.onWorkflowItemChanged11);
            this.Dokumentacja_OnChange.Activities.Add(this.logToHistoryListActivity53);
            this.Dokumentacja_OnChange.Activities.Add(this.ifElseActivity11);
            this.Dokumentacja_OnChange.Activities.Add(this.faultHandlersActivity18);
            this.Dokumentacja_OnChange.Name = "Dokumentacja_OnChange";
            // 
            // stateInitializationActivity10
            // 
            this.stateInitializationActivity10.Activities.Add(this.SetCT_Dokumentacja);
            this.stateInitializationActivity10.Activities.Add(this.logToHistoryListActivity9);
            this.stateInitializationActivity10.Activities.Add(this.setState_Dokumentacja);
            this.stateInitializationActivity10.Activities.Add(this.initializeWorkflow12);
            this.stateInitializationActivity10.Name = "stateInitializationActivity10";
            // 
            // Uruchomienie_OnChange
            // 
            this.Uruchomienie_OnChange.Activities.Add(this.onWorkflowItemChanged12);
            this.Uruchomienie_OnChange.Activities.Add(this.logToHistoryListActivity50);
            this.Uruchomienie_OnChange.Activities.Add(this.ifElseActivity123);
            this.Uruchomienie_OnChange.Activities.Add(this.faultHandlersActivity17);
            this.Uruchomienie_OnChange.Name = "Uruchomienie_OnChange";
            // 
            // stateInitializationActivity11
            // 
            this.stateInitializationActivity11.Activities.Add(this.SetCT_Uruchomienie);
            this.stateInitializationActivity11.Activities.Add(this.logToHistoryListActivity10);
            this.stateInitializationActivity11.Activities.Add(this.setState_Uruchomienie);
            this.stateInitializationActivity11.Activities.Add(this.initializeWorkflow11);
            this.stateInitializationActivity11.Name = "stateInitializationActivity11";
            // 
            // AkceptacjaUmowy_OnChange
            // 
            this.AkceptacjaUmowy_OnChange.Activities.Add(this.onWorkflowItemChanged10);
            this.AkceptacjaUmowy_OnChange.Activities.Add(this.logToHistoryListActivity46);
            this.AkceptacjaUmowy_OnChange.Activities.Add(this.TestAkceptacjaUmowy);
            this.AkceptacjaUmowy_OnChange.Activities.Add(this.faultHandlersActivity16);
            this.AkceptacjaUmowy_OnChange.Name = "AkceptacjaUmowy_OnChange";
            // 
            // stateInitializationActivity14
            // 
            this.stateInitializationActivity14.Activities.Add(this.SetCT_AkceptacjaUmowy);
            this.stateInitializationActivity14.Activities.Add(this.logToHistoryListActivity13);
            this.stateInitializationActivity14.Activities.Add(this.setState_AkceptacjaUmowy);
            this.stateInitializationActivity14.Activities.Add(this.initializeWorkflow10);
            this.stateInitializationActivity14.Name = "stateInitializationActivity14";
            // 
            // Umowa_OnChange
            // 
            this.Umowa_OnChange.Activities.Add(this.onWorkflowItemChanged9);
            this.Umowa_OnChange.Activities.Add(this.logToHistoryListActivity44);
            this.Umowa_OnChange.Activities.Add(this.ifElseActivity9);
            this.Umowa_OnChange.Activities.Add(this.faultHandlersActivity15);
            this.Umowa_OnChange.Name = "Umowa_OnChange";
            // 
            // stateInitializationActivity9
            // 
            this.stateInitializationActivity9.Activities.Add(this.SetCT_Umowa);
            this.stateInitializationActivity9.Activities.Add(this.logToHistoryListActivity8);
            this.stateInitializationActivity9.Activities.Add(this.setState_Umowa);
            this.stateInitializationActivity9.Activities.Add(this.initializeWorkflow9);
            this.stateInitializationActivity9.Name = "stateInitializationActivity9";
            // 
            // KorektaWniosku_OnChange
            // 
            this.KorektaWniosku_OnChange.Activities.Add(this.onWorkflowItemChanged8);
            this.KorektaWniosku_OnChange.Activities.Add(this.logToHistoryListActivity42);
            this.KorektaWniosku_OnChange.Activities.Add(this.ifElseActivity8);
            this.KorektaWniosku_OnChange.Activities.Add(this.faultHandlersActivity14);
            this.KorektaWniosku_OnChange.Name = "KorektaWniosku_OnChange";
            // 
            // stateInitializationActivity13
            // 
            this.stateInitializationActivity13.Activities.Add(this.SetCT_Wniosek1);
            this.stateInitializationActivity13.Activities.Add(this.logToHistoryListActivity12);
            this.stateInitializationActivity13.Activities.Add(this.setState_KorektaWniosku);
            this.stateInitializationActivity13.Activities.Add(this.initializeWorkflow8);
            this.stateInitializationActivity13.Name = "stateInitializationActivity13";
            // 
            // AkceptacjaWniosku_OnChange
            // 
            this.AkceptacjaWniosku_OnChange.Activities.Add(this.onWorkflowItemChanged7);
            this.AkceptacjaWniosku_OnChange.Activities.Add(this.logToHistoryListActivity38);
            this.AkceptacjaWniosku_OnChange.Activities.Add(this.ifElseActivity7);
            this.AkceptacjaWniosku_OnChange.Activities.Add(this.faultHandlersActivity13);
            this.AkceptacjaWniosku_OnChange.Name = "AkceptacjaWniosku_OnChange";
            // 
            // stateInitializationActivity8
            // 
            this.stateInitializationActivity8.Activities.Add(this.SetCT_AkceptacjaWniosku);
            this.stateInitializationActivity8.Activities.Add(this.logToHistoryListActivity7);
            this.stateInitializationActivity8.Activities.Add(this.setState_AkceptacjaWniosku);
            this.stateInitializationActivity8.Activities.Add(this.initializeWorkflow7);
            this.stateInitializationActivity8.Name = "stateInitializationActivity8";
            // 
            // Wniosek_OnChange
            // 
            this.Wniosek_OnChange.Activities.Add(this.onWorkflowItemChanged6);
            this.Wniosek_OnChange.Activities.Add(this.logToHistoryListActivity26);
            this.Wniosek_OnChange.Activities.Add(this.ifElseActivity6);
            this.Wniosek_OnChange.Activities.Add(this.faultHandlersActivity12);
            this.Wniosek_OnChange.Name = "Wniosek_OnChange";
            // 
            // stateInitializationActivity7
            // 
            this.stateInitializationActivity7.Activities.Add(this.SetCT_Wniosek);
            this.stateInitializationActivity7.Activities.Add(this.logToHistoryListActivity6);
            this.stateInitializationActivity7.Activities.Add(this.setState_Wniosek);
            this.stateInitializationActivity7.Activities.Add(this.initializeWorkflow6);
            this.stateInitializationActivity7.Activities.Add(this.codeDodajDoRozliczen);
            this.stateInitializationActivity7.Name = "stateInitializationActivity7";
            // 
            // KorektaOferty_OnChange
            // 
            this.KorektaOferty_OnChange.Activities.Add(this.onWorkflowItemChanged5);
            this.KorektaOferty_OnChange.Activities.Add(this.logToHistoryListActivity36);
            this.KorektaOferty_OnChange.Activities.Add(this.ifElseActivity5);
            this.KorektaOferty_OnChange.Activities.Add(this.faultHandlersActivity11);
            this.KorektaOferty_OnChange.Name = "KorektaOferty_OnChange";
            // 
            // stateInitializationActivity6
            // 
            this.stateInitializationActivity6.Activities.Add(this.SetCT_Oferta1);
            this.stateInitializationActivity6.Activities.Add(this.logKorektaOferty);
            this.stateInitializationActivity6.Activities.Add(this.setState_KorektaOferty);
            this.stateInitializationActivity6.Activities.Add(this.initializeWorkflow5);
            this.stateInitializationActivity6.Name = "stateInitializationActivity6";
            // 
            // AkceptacjaOferty_OnChange
            // 
            this.AkceptacjaOferty_OnChange.Activities.Add(this.onWorkflowItemChanged4);
            this.AkceptacjaOferty_OnChange.Activities.Add(this.logToHistoryListActivity25);
            this.AkceptacjaOferty_OnChange.Activities.Add(this.AkceptacjaOferty_Telemarketing);
            this.AkceptacjaOferty_OnChange.Activities.Add(this.faultHandlersActivity8);
            this.AkceptacjaOferty_OnChange.Name = "AkceptacjaOferty_OnChange";
            // 
            // stateInitializationActivity5
            // 
            this.stateInitializationActivity5.Activities.Add(this.SetCT_AkceptacjaOferty);
            this.stateInitializationActivity5.Activities.Add(this.logToHistoryListActivity5);
            this.stateInitializationActivity5.Activities.Add(this.setState_AkceptacjaOferty);
            this.stateInitializationActivity5.Activities.Add(this.initializeWorkflow4);
            this.stateInitializationActivity5.Name = "stateInitializationActivity5";
            // 
            // stateInitializationActivity2
            // 
            this.stateInitializationActivity2.Activities.Add(this.setState_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.SetCT_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.logToHistoryListActivity2);
            this.stateInitializationActivity2.Activities.Add(this.ifElseActivity1);
            this.stateInitializationActivity2.Activities.Add(this.setStateActivity26);
            this.stateInitializationActivity2.Name = "stateInitializationActivity2";
            // 
            // Oferta_OnChange
            // 
            this.Oferta_OnChange.Activities.Add(this.onWorkflowItemChanged2);
            this.Oferta_OnChange.Activities.Add(this.logToHistoryListActivity35);
            this.Oferta_OnChange.Activities.Add(this.Oferta_Routing);
            this.Oferta_OnChange.Activities.Add(this.faultHandlersActivity10);
            this.Oferta_OnChange.Name = "Oferta_OnChange";
            // 
            // stateInitializationActivity4
            // 
            this.stateInitializationActivity4.Activities.Add(this.SetCT_Oferta);
            this.stateInitializationActivity4.Activities.Add(this.logToHistoryListActivity15);
            this.stateInitializationActivity4.Activities.Add(this.setState_Oferta);
            this.stateInitializationActivity4.Activities.Add(this.initializeWorkflow3);
            this.stateInitializationActivity4.Name = "stateInitializationActivity4";
            // 
            // Telemarketing_OnChange
            // 
            this.Telemarketing_OnChange.Activities.Add(this.onWorkflowItemChanged3);
            this.Telemarketing_OnChange.Activities.Add(this.logToHistoryListActivity32);
            this.Telemarketing_OnChange.Activities.Add(this.Telemarketing_Routing);
            this.Telemarketing_OnChange.Activities.Add(this.faultHandlersActivity9);
            this.Telemarketing_OnChange.Name = "Telemarketing_OnChange";
            // 
            // stateInitializationActivity3
            // 
            this.stateInitializationActivity3.Activities.Add(this.SetCT_Telemarketing);
            this.stateInitializationActivity3.Activities.Add(this.logToHistoryListActivity16);
            this.stateInitializationActivity3.Activities.Add(this.setState_Telemarketing);
            this.stateInitializationActivity3.Activities.Add(this.initializeWorkflow2);
            this.stateInitializationActivity3.Name = "stateInitializationActivity3";
            // 
            // stateInitializationActivity1
            // 
            this.stateInitializationActivity1.Activities.Add(this.SetCT_Weryfikacja);
            this.stateInitializationActivity1.Activities.Add(this.setState_Weryfikacja);
            this.stateInitializationActivity1.Activities.Add(this.logToHistoryListActivity14);
            this.stateInitializationActivity1.Activities.Add(this.initializeWorkflow1);
            this.stateInitializationActivity1.Activities.Add(this.faultHandlersActivity4);
            this.stateInitializationActivity1.Name = "stateInitializationActivity1";
            // 
            // Weryfikacja_OnChange
            // 
            this.Weryfikacja_OnChange.Activities.Add(this.onWorkflowItemChanged13);
            this.Weryfikacja_OnChange.Activities.Add(this.logToHistoryListActivity28);
            this.Weryfikacja_OnChange.Activities.Add(this.Weryfikacja_Routing);
            this.Weryfikacja_OnChange.Activities.Add(this.faultHandlersActivity5);
            this.Weryfikacja_OnChange.Name = "Weryfikacja_OnChange";
            // 
            // stateInitializationActivity15
            // 
            this.stateInitializationActivity15.Activities.Add(this.logRouter);
            this.stateInitializationActivity15.Activities.Add(this.TestEtap);
            this.stateInitializationActivity15.Activities.Add(this.faultHandlersActivity3);
            this.stateInitializationActivity15.Name = "stateInitializationActivity15";
            // 
            // eventDrivenActivity1
            // 
            this.eventDrivenActivity1.Activities.Add(this.onWorkflowActivated1);
            this.eventDrivenActivity1.Activities.Add(this.logZainicjowany);
            this.eventDrivenActivity1.Activities.Add(this.codeSetup);
            this.eventDrivenActivity1.Activities.Add(this.StatusLead_Rozmowa);
            this.eventDrivenActivity1.Activities.Add(this.setStateActivity1);
            this.eventDrivenActivity1.Activities.Add(this.faultHandlersActivity1);
            this.eventDrivenActivity1.Name = "eventDrivenActivity1";
            // 
            // End
            // 
            this.End.Name = "End";
            // 
            // Rozliczenie
            // 
            this.Rozliczenie.Activities.Add(this.stateInitializationActivity12);
            this.Rozliczenie.Name = "Rozliczenie";
            // 
            // Dokumentacja
            // 
            this.Dokumentacja.Activities.Add(this.stateInitializationActivity10);
            this.Dokumentacja.Activities.Add(this.Dokumentacja_OnChange);
            this.Dokumentacja.Name = "Dokumentacja";
            // 
            // Uruchomienie
            // 
            this.Uruchomienie.Activities.Add(this.stateInitializationActivity11);
            this.Uruchomienie.Activities.Add(this.Uruchomienie_OnChange);
            this.Uruchomienie.Name = "Uruchomienie";
            // 
            // AkceptacjaUmowy
            // 
            this.AkceptacjaUmowy.Activities.Add(this.stateInitializationActivity14);
            this.AkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_OnChange);
            this.AkceptacjaUmowy.Name = "AkceptacjaUmowy";
            // 
            // Umowa
            // 
            this.Umowa.Activities.Add(this.stateInitializationActivity9);
            this.Umowa.Activities.Add(this.Umowa_OnChange);
            this.Umowa.Name = "Umowa";
            // 
            // KorektaWniosku
            // 
            this.KorektaWniosku.Activities.Add(this.stateInitializationActivity13);
            this.KorektaWniosku.Activities.Add(this.KorektaWniosku_OnChange);
            this.KorektaWniosku.Name = "KorektaWniosku";
            // 
            // AkceptacjaWniosku
            // 
            this.AkceptacjaWniosku.Activities.Add(this.stateInitializationActivity8);
            this.AkceptacjaWniosku.Activities.Add(this.AkceptacjaWniosku_OnChange);
            this.AkceptacjaWniosku.Name = "AkceptacjaWniosku";
            // 
            // Wniosek
            // 
            this.Wniosek.Activities.Add(this.stateInitializationActivity7);
            this.Wniosek.Activities.Add(this.Wniosek_OnChange);
            this.Wniosek.Name = "Wniosek";
            // 
            // KorektaOferty
            // 
            this.KorektaOferty.Activities.Add(this.stateInitializationActivity6);
            this.KorektaOferty.Activities.Add(this.KorektaOferty_OnChange);
            this.KorektaOferty.Name = "KorektaOferty";
            // 
            // AkceptacjaOferty
            // 
            this.AkceptacjaOferty.Activities.Add(this.stateInitializationActivity5);
            this.AkceptacjaOferty.Activities.Add(this.AkceptacjaOferty_OnChange);
            this.AkceptacjaOferty.Name = "AkceptacjaOferty";
            // 
            // Odrzucenie
            // 
            this.Odrzucenie.Activities.Add(this.stateInitializationActivity2);
            this.Odrzucenie.Name = "Odrzucenie";
            // 
            // Oferta
            // 
            this.Oferta.Activities.Add(this.stateInitializationActivity4);
            this.Oferta.Activities.Add(this.Oferta_OnChange);
            this.Oferta.Name = "Oferta";
            // 
            // Telemarketing
            // 
            this.Telemarketing.Activities.Add(this.stateInitializationActivity3);
            this.Telemarketing.Activities.Add(this.Telemarketing_OnChange);
            this.Telemarketing.Name = "Telemarketing";
            // 
            // Weryfikacja
            // 
            this.Weryfikacja.Activities.Add(this.Weryfikacja_OnChange);
            this.Weryfikacja.Activities.Add(this.stateInitializationActivity1);
            this.Weryfikacja.Name = "Weryfikacja";
            // 
            // Navigator
            // 
            this.Navigator.Activities.Add(this.stateInitializationActivity15);
            this.Navigator.Name = "Navigator";
            // 
            // Start
            // 
            this.Start.Activities.Add(this.eventDrivenActivity1);
            this.Start.Name = "Start";
            // 
            // Workflow1
            // 
            this.Activities.Add(this.Start);
            this.Activities.Add(this.Navigator);
            this.Activities.Add(this.Weryfikacja);
            this.Activities.Add(this.Telemarketing);
            this.Activities.Add(this.Oferta);
            this.Activities.Add(this.Odrzucenie);
            this.Activities.Add(this.AkceptacjaOferty);
            this.Activities.Add(this.KorektaOferty);
            this.Activities.Add(this.Wniosek);
            this.Activities.Add(this.AkceptacjaWniosku);
            this.Activities.Add(this.KorektaWniosku);
            this.Activities.Add(this.Umowa);
            this.Activities.Add(this.AkceptacjaUmowy);
            this.Activities.Add(this.Uruchomienie);
            this.Activities.Add(this.Dokumentacja);
            this.Activities.Add(this.Rozliczenie);
            this.Activities.Add(this.End);
            this.CompletedStateName = "End";
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "Start";
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity57;

        private CodeActivity ErrorHandler_Weryfikacja;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity67;

        private CodeActivity codeActivity10;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity66;

        private CodeActivity codeActivity9;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity65;

        private CodeActivity codeActivity8;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity64;

        private CodeActivity codeActivity7;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity63;

        private CodeActivity codeActivity6;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity62;

        private CodeActivity codeActivity5;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity61;

        private CodeActivity codeActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity60;

        private CodeActivity codeActivity3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity59;

        private CodeActivity codeActivity2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity58;

        private CodeActivity codeActivity1;

        private FaultHandlerActivity faultHandlerActivity15;

        private FaultHandlerActivity faultHandlerActivity14;

        private FaultHandlerActivity faultHandlerActivity13;

        private FaultHandlerActivity faultHandlerActivity12;

        private FaultHandlerActivity faultHandlerActivity11;

        private FaultHandlerActivity faultHandlerActivity10;

        private FaultHandlerActivity faultHandlerActivity9;

        private FaultHandlerActivity faultHandlerActivity8;

        private FaultHandlerActivity faultHandlerActivity7;

        private FaultHandlerActivity faultHandlerActivity6;

        private FaultHandlersActivity faultHandlersActivity18;

        private FaultHandlersActivity faultHandlersActivity17;

        private FaultHandlersActivity faultHandlersActivity16;

        private FaultHandlersActivity faultHandlersActivity15;

        private FaultHandlersActivity faultHandlersActivity14;

        private FaultHandlersActivity faultHandlersActivity13;

        private FaultHandlersActivity faultHandlersActivity12;

        private FaultHandlersActivity faultHandlersActivity11;

        private FaultHandlersActivity faultHandlersActivity10;

        private FaultHandlersActivity faultHandlersActivity9;

        private SetStateActivity setStateActivity29;

        private SetStateActivity setStateActivity42;

        private SetStateActivity setStateActivity41;

        private SetStateActivity setStateActivity40;

        private SetStateActivity setStateActivity39;

        private SetStateActivity setStateActivity38;

        private SetStateActivity setStateActivity37;

        private SetStateActivity setStateActivity36;

        private SetStateActivity setStateActivity35;

        private SetStateActivity setStateActivity34;

        private SetStateActivity setStateActivity33;

        private SetStateActivity setStateActivity32;

        private SetStateActivity setStateActivity31;

        private SetStateActivity setStateActivity30;

        private SetStateActivity setStateActivity28;

        private IfElseBranchActivity ifTelemarketing;

        private IfElseBranchActivity ifWeryfikacja;

        private IfElseActivity E;

        private IfElseBranchActivity ifOferta;

        private IfElseBranchActivity ifOdrzucenie;

        private IfElseBranchActivity ifAkceptacjaOferty;

        private IfElseBranchActivity ifKorektaOferty;

        private IfElseBranchActivity ifWniosek;

        private IfElseBranchActivity ifAkceptacjaWniosku;

        private IfElseBranchActivity ifKorektaWniosku;

        private IfElseBranchActivity ifUmowa;

        private IfElseBranchActivity ifAkceptacjaUmowy;

        private IfElseBranchActivity ifUruchomienie;

        private IfElseBranchActivity ifDokumentacja;

        private IfElseBranchActivity ifRozliczenie;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logNavigator;

        private IfElseBranchActivity Else2;

        private IfElseBranchActivity Else;

        private IfElseBranchActivity ifEtapNotNull;

        private IfElseActivity TestEtap;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity52;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity55;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity56;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity54;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity51;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity49;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity48;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity47;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity45;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity43;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity41;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity40;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity39;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity37;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity34;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity33;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity31;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity30;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity29;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity53;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity50;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity46;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity44;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity42;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity38;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity36;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity35;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity32;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity28;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity27;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity24;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity23;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity22;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity21;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity26;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity25;

        private CodeActivity ErrorHandler;

        private FaultHandlerActivity faultHandlerActivity1;

        private FaultHandlersActivity faultHandlersActivity8;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logErrorMessage;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow1;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow2;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow12;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow11;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow10;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow9;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow8;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow7;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow6;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow5;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow4;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow3;

        private CodeActivity codeDodajDoRozliczen;

        private SetStateActivity setStateActivity23;

        private IfElseBranchActivity StatusLeadu_Rozliczenie;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity20;

        private IfElseBranchActivity Uruchomiony_SendMailAllowed;

        private IfElseActivity ifElseActivity10;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity19;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity18;

        private IfElseBranchActivity AkceptacjaUmowy_SendEmailAllowed;

        private IfElseActivity ifElseActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity1;

        private IfElseBranchActivity AkceptacjaWniosku_SendMailAllowed;

        private IfElseActivity ifElseActivity3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity17;

        private IfElseBranchActivity AkceptacjaOferty_MailSendAllowed;

        private IfElseActivity ifElseActivity2;

        private IfElseBranchActivity Odrzucenie_MailSendAllowed;

        private IfElseActivity ifElseActivity1;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail_Uruchomiony;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail_WniosekZaakceptowany;

        private CodeActivity codeSetup;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail_OfertaZaakceptowana;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail_UmowaZaakceptowana;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail_Stracony;

        private IfElseBranchActivity Status_Lead_Else;

        private SetStateActivity setStateActivity8;

        private SetStateActivity setStateActivity7;

        private CodeActivity StatusOferta_Telefon;

        private SetStateActivity setStateActivity6;

        private SetStateActivity setStateActivity12;

        private CodeActivity StatusOferta_Stracony;

        private CodeActivity Komunikat_OfertaNiezaakceptowana;

        private SetStateActivity setStateActivity11;

        private CodeActivity StatusOferta_Wniosek;

        private CodeActivity Komunikat_AkceptacjaOferty;

        private IfElseBranchActivity KorektaOferty_AkceptacjaOferty;

        private IfElseBranchActivity AkceptacjaOferty_Telemarketing1;

        private IfElseBranchActivity AkceptacjaOferty_KorektaOferty;

        private IfElseBranchActivity AkceptacjaOferty_Odrzucenie;

        private IfElseBranchActivity AkceptacjaOferty_Wniosek;

        private IfElseActivity ifElseActivity5;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged5;

        private CodeActivity SetCT_Oferta1;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_KorektaOferty;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logKorektaOferty;

        private IfElseActivity AkceptacjaOferty_Telemarketing;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged4;

        private CodeActivity SetCT_AkceptacjaOferty;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_AkceptacjaOferty;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity5;

        private EventDrivenActivity KorektaOferty_OnChange;

        private StateInitializationActivity stateInitializationActivity6;

        private EventDrivenActivity AkceptacjaOferty_OnChange;

        private StateInitializationActivity stateInitializationActivity5;

        private StateActivity KorektaOferty;

        private StateActivity AkceptacjaOferty;

        private SetStateActivity setStateActivity17;

        private SetStateActivity setStateActivity16;

        private CodeActivity StatusWniosek_Stracony;

        private CodeActivity Komunikat_WniosekOdrzucony;

        private SetStateActivity setStateActivity15;

        private SetStateActivity setStateActivity14;

        private CodeActivity StatusWniosek_Umowa;

        private CodeActivity Komunikat_AkceptacjaWniosku;

        private SetStateActivity setStateActivity13;

        private IfElseBranchActivity KorektaWniosku_AkceptacjaWniosku;

        private IfElseBranchActivity AkceptacjaWniosku_Odrzucenie;

        private IfElseBranchActivity AkceptacjaWniosku_KorektaWniosku;

        private IfElseBranchActivity AkceptacjaWniosku_Umowa;

        private IfElseBranchActivity Wniosek_AkceptacjaWniosku;

        private IfElseActivity ifElseActivity8;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged8;

        private CodeActivity SetCT_Wniosek1;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_KorektaWniosku;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity12;

        private IfElseActivity ifElseActivity7;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged7;

        private CodeActivity SetCT_AkceptacjaWniosku;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_AkceptacjaWniosku;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity7;

        private IfElseActivity ifElseActivity6;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged6;

        private CodeActivity SetCT_Wniosek;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Wniosek;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity6;

        private EventDrivenActivity KorektaWniosku_OnChange;

        private StateInitializationActivity stateInitializationActivity13;

        private EventDrivenActivity AkceptacjaWniosku_OnChange;

        private StateInitializationActivity stateInitializationActivity8;

        private EventDrivenActivity Wniosek_OnChange;

        private StateInitializationActivity stateInitializationActivity7;

        private StateActivity KorektaWniosku;

        private StateActivity AkceptacjaWniosku;

        private StateActivity Wniosek;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity4;

        private SetStateActivity setStateActivity21;

        private SetStateActivity setStateActivity22;

        private SetStateActivity setStateActivity18;

        private CodeActivity StatusUmowa_Telefon;

        private CodeActivity Komunikat_UmowaNiezaakceptowana;

        private SetStateActivity setStateActivity24;

        private CodeActivity StatusUmowa_Stracony;

        private CodeActivity Komunikat_UmowaStracona;

        private SetStateActivity setStateActivity20;

        private CodeActivity StatusUmowa_Uruchomienie;

        private CodeActivity Komunikat_UmowaUruchomiona;

        private SetStateActivity setStateActivity19;

        private FaultHandlerActivity faultHandlerActivity2;

        private IfElseBranchActivity Dokumentacja_Rozliczenie;

        private IfElseBranchActivity Uruchomienie_Dokumentacja;

        private IfElseBranchActivity AkceptacjaUmowy_Telemarketing;

        private IfElseBranchActivity AkceptacjaUmowy_Odrzucenie;

        private IfElseBranchActivity AkceptacjaUmowy_Uruchomienie;

        private IfElseBranchActivity Umowa_AkceptacjaUmowy;

        private FaultHandlersActivity faultHandlersActivity2;

        private SetStateActivity setStateActivity25;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity3;

        private CodeActivity nRozliczenie_DodajDoRozliczen;

        private CodeActivity SetCT_Rozliczenie;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Rozliczenie;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity11;

        private IfElseActivity ifElseActivity11;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged11;

        private CodeActivity SetCT_Dokumentacja;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Dokumentacja;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity9;

        private IfElseActivity ifElseActivity123;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged12;

        private CodeActivity SetCT_Uruchomienie;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Uruchomienie;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity10;

        private IfElseActivity TestAkceptacjaUmowy;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged10;

        private CodeActivity SetCT_AkceptacjaUmowy;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_AkceptacjaUmowy;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity13;

        private IfElseActivity ifElseActivity9;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged9;

        private CodeActivity SetCT_Umowa;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Umowa;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity8;

        private StateInitializationActivity stateInitializationActivity12;

        private EventDrivenActivity Dokumentacja_OnChange;

        private StateInitializationActivity stateInitializationActivity10;

        private EventDrivenActivity Uruchomienie_OnChange;

        private StateInitializationActivity stateInitializationActivity11;

        private EventDrivenActivity AkceptacjaUmowy_OnChange;

        private StateInitializationActivity stateInitializationActivity14;

        private EventDrivenActivity Umowa_OnChange;

        private StateInitializationActivity stateInitializationActivity9;

        private StateActivity End;

        private StateActivity Rozliczenie;

        private StateActivity Dokumentacja;

        private StateActivity Uruchomienie;

        private StateActivity AkceptacjaUmowy;

        private StateActivity Umowa;

        private SetStateActivity setStateActivity5;

        private SetStateActivity setStateActivity10;

        private CodeActivity StatusTelefon_Stracony;

        private SetStateActivity setStateActivity9;

        private CodeActivity StatusTelefon_Oferta;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_WefyfikacjaInit;

        private SetStateActivity setStateActivity2;

        private CodeActivity StatusRozmowa_Stracony;

        private SetStateActivity setStateActivity4;

        private CodeActivity StatusRozmowa_Telefon;

        private SetStateActivity setStateActivity3;

        private CodeActivity StatusRozmowa_Oferta;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_NavigatorInit;

        private SetStateActivity setStateActivity27;

        private SetStateActivity Navigator_Stracony;

        private SetStateActivity Navigator_Uruchomienie;

        private SetStateActivity Navigator_Umowa;

        private SetStateActivity Navigator_Wniosek;

        private SetStateActivity Navigator_Oferta;

        private SetStateActivity Navigator_Telemarketing;

        private IfElseBranchActivity Oferta_AkceptacjaOferty;

        private IfElseBranchActivity Telemarketing_Odrzucenie;

        private IfElseBranchActivity Telemarketing_Oferta;

        private FaultHandlerActivity faultHandlerActivity4;

        private FaultHandlerActivity faultHandlerActivity5;

        private FaultHandlersActivity faultHandlersActivity6;

        private IfElseBranchActivity Weryfikacja_Odrzucenie;

        private IfElseBranchActivity Weryfikacja_Telemarketing;

        private IfElseBranchActivity Weryfikacja_Oferta;

        private FaultHandlerActivity faultHandlerActivity3;

        private FaultHandlersActivity faultHandlersActivity7;

        private IfElseBranchActivity StatusLeadu_Stracony;

        private IfElseBranchActivity StatusLeadu_Uruchomiony;

        private IfElseBranchActivity StatusLeadu_Umowa;

        private IfElseBranchActivity StatusLeadu_Wniosek;

        private IfElseBranchActivity StatusLeadu_Oferta;

        private IfElseBranchActivity StatusLeadu_Telefon;

        private SetStateActivity setStateActivity26;

        private CodeActivity SetCT_Odrzucony;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity2;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Odrzucony;

        private IfElseActivity Oferta_Routing;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged2;

        private CodeActivity SetCT_Oferta;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Oferta;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity15;

        private IfElseActivity Telemarketing_Routing;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged3;

        private CodeActivity SetCT_Telemarketing;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Telemarketing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity16;

        private FaultHandlersActivity faultHandlersActivity4;

        private CodeActivity SetCT_Weryfikacja;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity14;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Weryfikacja;

        private FaultHandlersActivity faultHandlersActivity5;

        private IfElseActivity Weryfikacja_Routing;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged13;

        private FaultHandlersActivity faultHandlersActivity3;

        private IfElseActivity Navigator_Routing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logRouter;

        private FaultHandlersActivity faultHandlersActivity1;

        private SetStateActivity setStateActivity1;

        private CodeActivity StatusLead_Rozmowa;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logZainicjowany;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;

        private StateInitializationActivity stateInitializationActivity2;

        private EventDrivenActivity Oferta_OnChange;

        private StateInitializationActivity stateInitializationActivity4;

        private EventDrivenActivity Telemarketing_OnChange;

        private StateInitializationActivity stateInitializationActivity3;

        private StateInitializationActivity stateInitializationActivity1;

        private EventDrivenActivity Weryfikacja_OnChange;

        private StateInitializationActivity stateInitializationActivity15;

        private EventDrivenActivity eventDrivenActivity1;

        private StateActivity Odrzucenie;

        private StateActivity Oferta;

        private StateActivity Telemarketing;

        private StateActivity Weryfikacja;

        private StateActivity Navigator;

        private StateActivity Start;





































































































































































    }
}
