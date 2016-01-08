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
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind17 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind18 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind19 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind20 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind21 = new System.Workflow.ComponentModel.ActivityBind();
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
            System.Workflow.ComponentModel.ActivityBind activitybind47 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind48 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind49 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind50 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind51 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind52 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind53 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind54 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind55 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind56 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind57 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind58 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind59 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind60 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind61 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind62 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind63 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind64 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind65 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind66 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind67 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind68 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind69 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind70 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind71 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind72 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind73 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind74 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind75 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind76 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind77 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind78 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind79 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind80 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind81 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind82 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind83 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind84 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind85 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind86 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind87 = new System.Workflow.ComponentModel.ActivityBind();
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
            System.Workflow.ComponentModel.ActivityBind activitybind88 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
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
            System.Workflow.ComponentModel.ActivityBind activitybind89 = new System.Workflow.ComponentModel.ActivityBind();
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
            this.codeActivity26 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity67 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity10 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity81 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity21 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity54 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity97 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity25 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity66 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity9 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity80 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity22 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity10 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity51 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity96 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity24 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity65 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity8 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity79 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
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
            this.logToHistoryListActivity95 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity23 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity64 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity7 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity78 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity19 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity45 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity94 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity22 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity63 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity6 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity77 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity17 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity43 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity93 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity21 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity62 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity5 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity76 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
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
            this.logToHistoryListActivity92 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity20 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity61 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity4 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity75 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity13 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity27 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity91 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity19 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity60 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity74 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity8 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity37 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity90 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity18 = new System.Workflow.Activities.CodeActivity();
            this.logErrorMessage = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ErrorHandler = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity73 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
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
            this.logToHistoryListActivity89 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity17 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity88 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity16 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity17 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_Stracony = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity59 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity72 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity5 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity87 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity15 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity58 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity71 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity10 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Stracony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity34 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity9 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity33 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity86 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity14 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity85 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity13 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity57 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ErrorHandler_Weryfikacja = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity70 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity31 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity30 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity29 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity84 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity12 = new System.Workflow.Activities.CodeActivity();
            this.Navigator_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity69 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Navigator_Routing_ver2 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity68 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity83 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity11 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlerActivity2 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity15 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity12 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Dokumentacja_Rozliczenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity28 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity14 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity11 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Uruchomienie_Dokumentacja = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity27 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity13 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity10 = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Uruchomienie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity26 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity12 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity9 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Umowa_AkceptacjaUmowy = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity25 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity11 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity8 = new System.Workflow.Activities.IfElseBranchActivity();
            this.KorektaWniosku_AkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity24 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity10 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity7 = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_KorektaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_Umowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity23 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity9 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity6 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Wniosek_AkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity22 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity8 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity5 = new System.Workflow.Activities.IfElseBranchActivity();
            this.KorektaOferty_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity21 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity1 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity4 = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Telemarketing1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_KorektaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Wniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity20 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity19 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Odrzucenie_MailSendAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity7 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity3 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Oferta_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity18 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity6 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity17 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity4 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity5 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlersActivity6 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity3 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Else = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifEtapNotNull = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity16 = new System.Workflow.ComponentModel.FaultHandlerActivity();
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
            this.faultHandlersActivity29 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow12 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Dokumentacja = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity9 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Dokumentacja = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity17 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity123 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity50 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged12 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity28 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow11 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Uruchomienie = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity10 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Uruchomienie = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity16 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.TestAkceptacjaUmowy = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity46 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged10 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity27 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow10 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_AkceptacjaUmowy = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity13 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_AkceptacjaUmowy = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity15 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity9 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity44 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Update_Item = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowItemChanged9 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity26 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow9 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Umowa = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity8 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Umowa = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity14 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity8 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity42 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged8 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity30 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow8 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_KorektaWniosku = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity12 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Wniosek1 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity13 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity7 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity38 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged7 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity25 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow7 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_AkceptacjaWniosku = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity7 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_AkceptacjaWniosku = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity12 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity6 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity26 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged6 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity24 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow6 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.codeDodajDoRozliczen = new System.Workflow.Activities.CodeActivity();
            this.setState_Wniosek = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity6 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Wniosek = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity11 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.ifElseActivity5 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity36 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged5 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity23 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow5 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_KorektaOferty = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logKorektaOferty = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Oferta1 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity8 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.AkceptacjaOferty_Telemarketing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity25 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged4 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity22 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow4 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_AkceptacjaOferty = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity5 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_AkceptacjaOferty = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity21 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity26 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity2 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Odrzucony = new System.Workflow.Activities.CodeActivity();
            this.setState_Odrzucony = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.faultHandlersActivity10 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Oferta_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity35 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged2 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity20 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.initializeWorkflow3 = new Microsoft.SharePoint.WorkflowActions.InitializeWorkflow();
            this.setState_Oferta = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity15 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Oferta = new System.Workflow.Activities.CodeActivity();
            this.faultHandlersActivity9 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Telemarketing_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity32 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged3 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity19 = new System.Workflow.ComponentModel.FaultHandlersActivity();
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
            this.codeSetup = new System.Workflow.Activities.CodeActivity();
            this.logZainicjowany = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowActivated2 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
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
            correlationtoken2.Name = "myToken";
            correlationtoken2.OwnerActivityName = "Workflow1";
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
            this.sendEmail_WniosekZaakceptowany.CorrelationToken = correlationtoken2;
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
            this.sendEmail_OfertaZaakceptowana.CorrelationToken = correlationtoken2;
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
            activitybind26.Name = "Workflow1";
            activitybind26.Path = "logErrorMessage_HistoryDescription";
            activitybind27.Name = "Workflow1";
            activitybind27.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity4.Name = "logToHistoryListActivity4";
            this.logToHistoryListActivity4.OtherData = "";
            this.logToHistoryListActivity4.UserId = -1;
            this.logToHistoryListActivity4.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind26)));
            this.logToHistoryListActivity4.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind27)));
            // 
            // codeActivity26
            // 
            this.codeActivity26.Name = "codeActivity26";
            this.codeActivity26.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity67
            // 
            this.logToHistoryListActivity67.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity67.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind28.Name = "Workflow1";
            activitybind28.Path = "logErrorMessage_HistoryDescription";
            activitybind29.Name = "Workflow1";
            activitybind29.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity67.Name = "logToHistoryListActivity67";
            this.logToHistoryListActivity67.OtherData = "";
            this.logToHistoryListActivity67.UserId = -1;
            this.logToHistoryListActivity67.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind28)));
            this.logToHistoryListActivity67.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind29)));
            // 
            // codeActivity10
            // 
            this.codeActivity10.Name = "codeActivity10";
            this.codeActivity10.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity81
            // 
            this.logToHistoryListActivity81.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity81.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity81.HistoryDescription = "Dokumentacja_Null";
            this.logToHistoryListActivity81.HistoryOutcome = "";
            this.logToHistoryListActivity81.Name = "logToHistoryListActivity81";
            this.logToHistoryListActivity81.OtherData = "";
            this.logToHistoryListActivity81.UserId = -1;
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
            // logToHistoryListActivity97
            // 
            this.logToHistoryListActivity97.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity97.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind30.Name = "Workflow1";
            activitybind30.Path = "logErrorMessage_HistoryDescription";
            activitybind31.Name = "Workflow1";
            activitybind31.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity97.Name = "logToHistoryListActivity97";
            this.logToHistoryListActivity97.OtherData = "";
            this.logToHistoryListActivity97.UserId = -1;
            this.logToHistoryListActivity97.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind30)));
            this.logToHistoryListActivity97.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind31)));
            // 
            // codeActivity25
            // 
            this.codeActivity25.Name = "codeActivity25";
            this.codeActivity25.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity66
            // 
            this.logToHistoryListActivity66.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity66.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind32.Name = "Workflow1";
            activitybind32.Path = "logErrorMessage_HistoryDescription";
            activitybind33.Name = "Workflow1";
            activitybind33.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity66.Name = "logToHistoryListActivity66";
            this.logToHistoryListActivity66.OtherData = "";
            this.logToHistoryListActivity66.UserId = -1;
            this.logToHistoryListActivity66.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind32)));
            this.logToHistoryListActivity66.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind33)));
            // 
            // codeActivity9
            // 
            this.codeActivity9.Name = "codeActivity9";
            this.codeActivity9.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity80
            // 
            this.logToHistoryListActivity80.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity80.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity80.HistoryDescription = "Uruchomienie_Null";
            this.logToHistoryListActivity80.HistoryOutcome = "";
            this.logToHistoryListActivity80.Name = "logToHistoryListActivity80";
            this.logToHistoryListActivity80.OtherData = "";
            this.logToHistoryListActivity80.UserId = -1;
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
            // logToHistoryListActivity96
            // 
            this.logToHistoryListActivity96.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity96.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind34.Name = "Workflow1";
            activitybind34.Path = "logErrorMessage_HistoryDescription";
            activitybind35.Name = "Workflow1";
            activitybind35.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity96.Name = "logToHistoryListActivity96";
            this.logToHistoryListActivity96.OtherData = "";
            this.logToHistoryListActivity96.UserId = -1;
            this.logToHistoryListActivity96.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind34)));
            this.logToHistoryListActivity96.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind35)));
            // 
            // codeActivity24
            // 
            this.codeActivity24.Name = "codeActivity24";
            this.codeActivity24.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity65
            // 
            this.logToHistoryListActivity65.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity65.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind36.Name = "Workflow1";
            activitybind36.Path = "logErrorMessage_HistoryDescription";
            activitybind37.Name = "Workflow1";
            activitybind37.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity65.Name = "logToHistoryListActivity65";
            this.logToHistoryListActivity65.OtherData = "";
            this.logToHistoryListActivity65.UserId = -1;
            this.logToHistoryListActivity65.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind36)));
            this.logToHistoryListActivity65.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind37)));
            // 
            // codeActivity8
            // 
            this.codeActivity8.Name = "codeActivity8";
            this.codeActivity8.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity79
            // 
            this.logToHistoryListActivity79.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity79.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity79.HistoryDescription = "AkceptacjaUmowy_Null";
            this.logToHistoryListActivity79.HistoryOutcome = "";
            this.logToHistoryListActivity79.Name = "logToHistoryListActivity79";
            this.logToHistoryListActivity79.OtherData = "";
            this.logToHistoryListActivity79.UserId = -1;
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
            // logToHistoryListActivity95
            // 
            this.logToHistoryListActivity95.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity95.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind38.Name = "Workflow1";
            activitybind38.Path = "logErrorMessage_HistoryDescription";
            activitybind39.Name = "Workflow1";
            activitybind39.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity95.Name = "logToHistoryListActivity95";
            this.logToHistoryListActivity95.OtherData = "";
            this.logToHistoryListActivity95.UserId = -1;
            this.logToHistoryListActivity95.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind38)));
            this.logToHistoryListActivity95.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind39)));
            // 
            // codeActivity23
            // 
            this.codeActivity23.Name = "codeActivity23";
            this.codeActivity23.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity64
            // 
            this.logToHistoryListActivity64.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity64.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind40.Name = "Workflow1";
            activitybind40.Path = "logErrorMessage_HistoryDescription";
            activitybind41.Name = "Workflow1";
            activitybind41.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity64.Name = "logToHistoryListActivity64";
            this.logToHistoryListActivity64.OtherData = "";
            this.logToHistoryListActivity64.UserId = -1;
            this.logToHistoryListActivity64.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind40)));
            this.logToHistoryListActivity64.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind41)));
            // 
            // codeActivity7
            // 
            this.codeActivity7.Name = "codeActivity7";
            this.codeActivity7.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity78
            // 
            this.logToHistoryListActivity78.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity78.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity78.HistoryDescription = "Umowa_Null";
            this.logToHistoryListActivity78.HistoryOutcome = "";
            this.logToHistoryListActivity78.Name = "logToHistoryListActivity78";
            this.logToHistoryListActivity78.OtherData = "";
            this.logToHistoryListActivity78.UserId = -1;
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
            // logToHistoryListActivity94
            // 
            this.logToHistoryListActivity94.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity94.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind42.Name = "Workflow1";
            activitybind42.Path = "logErrorMessage_HistoryDescription";
            activitybind43.Name = "Workflow1";
            activitybind43.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity94.Name = "logToHistoryListActivity94";
            this.logToHistoryListActivity94.OtherData = "";
            this.logToHistoryListActivity94.UserId = -1;
            this.logToHistoryListActivity94.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind42)));
            this.logToHistoryListActivity94.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind43)));
            // 
            // codeActivity22
            // 
            this.codeActivity22.Name = "codeActivity22";
            this.codeActivity22.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity63
            // 
            this.logToHistoryListActivity63.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity63.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind44.Name = "Workflow1";
            activitybind44.Path = "logErrorMessage_HistoryDescription";
            activitybind45.Name = "Workflow1";
            activitybind45.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity63.Name = "logToHistoryListActivity63";
            this.logToHistoryListActivity63.OtherData = "";
            this.logToHistoryListActivity63.UserId = -1;
            this.logToHistoryListActivity63.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind44)));
            this.logToHistoryListActivity63.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind45)));
            // 
            // codeActivity6
            // 
            this.codeActivity6.Name = "codeActivity6";
            this.codeActivity6.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity77
            // 
            this.logToHistoryListActivity77.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity77.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity77.HistoryDescription = "KorektaWniosku_Null";
            this.logToHistoryListActivity77.HistoryOutcome = "";
            this.logToHistoryListActivity77.Name = "logToHistoryListActivity77";
            this.logToHistoryListActivity77.OtherData = "";
            this.logToHistoryListActivity77.UserId = -1;
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
            // logToHistoryListActivity93
            // 
            this.logToHistoryListActivity93.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity93.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind46.Name = "Workflow1";
            activitybind46.Path = "logErrorMessage_HistoryDescription";
            activitybind47.Name = "Workflow1";
            activitybind47.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity93.Name = "logToHistoryListActivity93";
            this.logToHistoryListActivity93.OtherData = "";
            this.logToHistoryListActivity93.UserId = -1;
            this.logToHistoryListActivity93.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind46)));
            this.logToHistoryListActivity93.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind47)));
            // 
            // codeActivity21
            // 
            this.codeActivity21.Name = "codeActivity21";
            this.codeActivity21.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity62
            // 
            this.logToHistoryListActivity62.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity62.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind48.Name = "Workflow1";
            activitybind48.Path = "logErrorMessage_HistoryDescription";
            activitybind49.Name = "Workflow1";
            activitybind49.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity62.Name = "logToHistoryListActivity62";
            this.logToHistoryListActivity62.OtherData = "";
            this.logToHistoryListActivity62.UserId = -1;
            this.logToHistoryListActivity62.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind48)));
            this.logToHistoryListActivity62.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind49)));
            // 
            // codeActivity5
            // 
            this.codeActivity5.Name = "codeActivity5";
            this.codeActivity5.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity76
            // 
            this.logToHistoryListActivity76.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity76.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity76.HistoryDescription = "AkceptacjaWniosku_Null";
            this.logToHistoryListActivity76.HistoryOutcome = "";
            this.logToHistoryListActivity76.Name = "logToHistoryListActivity76";
            this.logToHistoryListActivity76.OtherData = "";
            this.logToHistoryListActivity76.UserId = -1;
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
            // logToHistoryListActivity92
            // 
            this.logToHistoryListActivity92.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity92.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind50.Name = "Workflow1";
            activitybind50.Path = "logErrorMessage_HistoryDescription";
            activitybind51.Name = "Workflow1";
            activitybind51.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity92.Name = "logToHistoryListActivity92";
            this.logToHistoryListActivity92.OtherData = "";
            this.logToHistoryListActivity92.UserId = -1;
            this.logToHistoryListActivity92.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind50)));
            this.logToHistoryListActivity92.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind51)));
            // 
            // codeActivity20
            // 
            this.codeActivity20.Name = "codeActivity20";
            this.codeActivity20.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity61
            // 
            this.logToHistoryListActivity61.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity61.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind52.Name = "Workflow1";
            activitybind52.Path = "logErrorMessage_HistoryDescription";
            activitybind53.Name = "Workflow1";
            activitybind53.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity61.Name = "logToHistoryListActivity61";
            this.logToHistoryListActivity61.OtherData = "";
            this.logToHistoryListActivity61.UserId = -1;
            this.logToHistoryListActivity61.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind52)));
            this.logToHistoryListActivity61.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind53)));
            // 
            // codeActivity4
            // 
            this.codeActivity4.Name = "codeActivity4";
            this.codeActivity4.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity75
            // 
            this.logToHistoryListActivity75.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity75.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity75.HistoryDescription = "Wniosek_Null";
            this.logToHistoryListActivity75.HistoryOutcome = "";
            this.logToHistoryListActivity75.Name = "logToHistoryListActivity75";
            this.logToHistoryListActivity75.OtherData = "";
            this.logToHistoryListActivity75.UserId = -1;
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
            // logToHistoryListActivity91
            // 
            this.logToHistoryListActivity91.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity91.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind54.Name = "Workflow1";
            activitybind54.Path = "logErrorMessage_HistoryDescription";
            activitybind55.Name = "Workflow1";
            activitybind55.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity91.Name = "logToHistoryListActivity91";
            this.logToHistoryListActivity91.OtherData = "";
            this.logToHistoryListActivity91.UserId = -1;
            this.logToHistoryListActivity91.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind54)));
            this.logToHistoryListActivity91.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind55)));
            // 
            // codeActivity19
            // 
            this.codeActivity19.Name = "codeActivity19";
            this.codeActivity19.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity60
            // 
            this.logToHistoryListActivity60.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity60.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind56.Name = "Workflow1";
            activitybind56.Path = "logErrorMessage_HistoryDescription";
            activitybind57.Name = "Workflow1";
            activitybind57.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity60.Name = "logToHistoryListActivity60";
            this.logToHistoryListActivity60.OtherData = "";
            this.logToHistoryListActivity60.UserId = -1;
            this.logToHistoryListActivity60.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind56)));
            this.logToHistoryListActivity60.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind57)));
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity74
            // 
            this.logToHistoryListActivity74.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity74.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity74.HistoryDescription = "KorektaOferty_Null";
            this.logToHistoryListActivity74.HistoryOutcome = "";
            this.logToHistoryListActivity74.Name = "logToHistoryListActivity74";
            this.logToHistoryListActivity74.OtherData = "";
            this.logToHistoryListActivity74.UserId = -1;
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
            // logToHistoryListActivity90
            // 
            this.logToHistoryListActivity90.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity90.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind58.Name = "Workflow1";
            activitybind58.Path = "logErrorMessage_HistoryDescription";
            activitybind59.Name = "Workflow1";
            activitybind59.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity90.Name = "logToHistoryListActivity90";
            this.logToHistoryListActivity90.OtherData = "";
            this.logToHistoryListActivity90.UserId = -1;
            this.logToHistoryListActivity90.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind58)));
            this.logToHistoryListActivity90.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind59)));
            // 
            // codeActivity18
            // 
            this.codeActivity18.Name = "codeActivity18";
            this.codeActivity18.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logErrorMessage
            // 
            this.logErrorMessage.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logErrorMessage.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind60.Name = "Workflow1";
            activitybind60.Path = "logErrorMessage_HistoryDescription";
            activitybind61.Name = "Workflow1";
            activitybind61.Path = "logErrorMessage_HistoryOutcome";
            this.logErrorMessage.Name = "logErrorMessage";
            this.logErrorMessage.OtherData = "";
            this.logErrorMessage.UserId = -1;
            this.logErrorMessage.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind60)));
            this.logErrorMessage.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind61)));
            // 
            // ErrorHandler
            // 
            this.ErrorHandler.Name = "ErrorHandler";
            this.ErrorHandler.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity73
            // 
            this.logToHistoryListActivity73.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity73.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity73.HistoryDescription = "AkceptacjaOferty_Null";
            this.logToHistoryListActivity73.HistoryOutcome = "";
            this.logToHistoryListActivity73.Name = "logToHistoryListActivity73";
            this.logToHistoryListActivity73.OtherData = "";
            this.logToHistoryListActivity73.UserId = -1;
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
            // logToHistoryListActivity89
            // 
            this.logToHistoryListActivity89.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity89.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind62.Name = "Workflow1";
            activitybind62.Path = "logErrorMessage_HistoryDescription";
            activitybind63.Name = "Workflow1";
            activitybind63.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity89.Name = "logToHistoryListActivity89";
            this.logToHistoryListActivity89.OtherData = "";
            this.logToHistoryListActivity89.UserId = -1;
            this.logToHistoryListActivity89.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind62)));
            this.logToHistoryListActivity89.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind63)));
            // 
            // codeActivity17
            // 
            this.codeActivity17.Name = "codeActivity17";
            this.codeActivity17.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity88
            // 
            this.logToHistoryListActivity88.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity88.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind64.Name = "Workflow1";
            activitybind64.Path = "logErrorMessage_HistoryDescription";
            activitybind65.Name = "Workflow1";
            activitybind65.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity88.Name = "logToHistoryListActivity88";
            this.logToHistoryListActivity88.OtherData = "";
            this.logToHistoryListActivity88.UserId = -1;
            this.logToHistoryListActivity88.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind64)));
            this.logToHistoryListActivity88.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind65)));
            // 
            // codeActivity16
            // 
            this.codeActivity16.Name = "codeActivity16";
            this.codeActivity16.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
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
            activitybind66.Name = "Workflow1";
            activitybind66.Path = "Mail_BCC";
            activitybind67.Name = "Workflow1";
            activitybind67.Path = "Mail_Body";
            activitybind68.Name = "Workflow1";
            activitybind68.Path = "Mail_CC";
            this.sendEmail_Stracony.CorrelationToken = correlationtoken2;
            activitybind69.Name = "Workflow1";
            activitybind69.Path = "Mail_From";
            this.sendEmail_Stracony.Headers = null;
            this.sendEmail_Stracony.IncludeStatus = false;
            this.sendEmail_Stracony.Name = "sendEmail_Stracony";
            activitybind70.Name = "Workflow1";
            activitybind70.Path = "Mail_Subject";
            activitybind71.Name = "Workflow1";
            activitybind71.Path = "Mail_To";
            this.sendEmail_Stracony.MethodInvoking += new System.EventHandler(this.sendEmail_Stracony_MethodInvoking);
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind71)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind70)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind67)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind66)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind68)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind69)));
            // 
            // logToHistoryListActivity59
            // 
            this.logToHistoryListActivity59.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity59.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind72.Name = "Workflow1";
            activitybind72.Path = "logErrorMessage_HistoryDescription";
            activitybind73.Name = "Workflow1";
            activitybind73.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity59.Name = "logToHistoryListActivity59";
            this.logToHistoryListActivity59.OtherData = "";
            this.logToHistoryListActivity59.UserId = -1;
            this.logToHistoryListActivity59.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind72)));
            this.logToHistoryListActivity59.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind73)));
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity72
            // 
            this.logToHistoryListActivity72.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity72.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity72.HistoryDescription = "Oferta_Null";
            this.logToHistoryListActivity72.HistoryOutcome = "";
            this.logToHistoryListActivity72.Name = "logToHistoryListActivity72";
            this.logToHistoryListActivity72.OtherData = "";
            this.logToHistoryListActivity72.UserId = -1;
            // 
            // setStateActivity5
            // 
            this.setStateActivity5.Name = "setStateActivity5";
            this.setStateActivity5.TargetStateName = "AkceptacjaOferty";
            // 
            // logToHistoryListActivity87
            // 
            this.logToHistoryListActivity87.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity87.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind74.Name = "Workflow1";
            activitybind74.Path = "logErrorMessage_HistoryDescription";
            activitybind75.Name = "Workflow1";
            activitybind75.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity87.Name = "logToHistoryListActivity87";
            this.logToHistoryListActivity87.OtherData = "";
            this.logToHistoryListActivity87.UserId = -1;
            this.logToHistoryListActivity87.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind74)));
            this.logToHistoryListActivity87.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind75)));
            // 
            // codeActivity15
            // 
            this.codeActivity15.Name = "codeActivity15";
            this.codeActivity15.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity58
            // 
            this.logToHistoryListActivity58.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity58.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind76.Name = "Workflow1";
            activitybind76.Path = "logErrorMessage_HistoryDescription";
            activitybind77.Name = "Workflow1";
            activitybind77.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity58.Name = "logToHistoryListActivity58";
            this.logToHistoryListActivity58.OtherData = "";
            this.logToHistoryListActivity58.UserId = -1;
            this.logToHistoryListActivity58.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind76)));
            this.logToHistoryListActivity58.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind77)));
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity71
            // 
            this.logToHistoryListActivity71.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity71.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity71.HistoryDescription = "Telemarketing_Null";
            this.logToHistoryListActivity71.HistoryOutcome = "";
            this.logToHistoryListActivity71.Name = "logToHistoryListActivity71";
            this.logToHistoryListActivity71.OtherData = "";
            this.logToHistoryListActivity71.UserId = -1;
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
            // logToHistoryListActivity86
            // 
            this.logToHistoryListActivity86.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity86.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind78.Name = "Workflow1";
            activitybind78.Path = "logErrorMessage_HistoryDescription";
            activitybind79.Name = "Workflow1";
            activitybind79.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity86.Name = "logToHistoryListActivity86";
            this.logToHistoryListActivity86.OtherData = "";
            this.logToHistoryListActivity86.UserId = -1;
            this.logToHistoryListActivity86.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind78)));
            this.logToHistoryListActivity86.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind79)));
            // 
            // codeActivity14
            // 
            this.codeActivity14.Name = "codeActivity14";
            this.codeActivity14.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity85
            // 
            this.logToHistoryListActivity85.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity85.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind80.Name = "Workflow1";
            activitybind80.Path = "logErrorMessage_HistoryDescription";
            activitybind81.Name = "Workflow1";
            activitybind81.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity85.Name = "logToHistoryListActivity85";
            this.logToHistoryListActivity85.OtherData = "";
            this.logToHistoryListActivity85.UserId = -1;
            this.logToHistoryListActivity85.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind80)));
            this.logToHistoryListActivity85.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind81)));
            // 
            // codeActivity13
            // 
            this.codeActivity13.Name = "codeActivity13";
            this.codeActivity13.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity57
            // 
            this.logToHistoryListActivity57.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity57.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind82.Name = "Workflow1";
            activitybind82.Path = "logErrorMessage_HistoryDescription";
            activitybind83.Name = "Workflow1";
            activitybind83.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity57.Name = "logToHistoryListActivity57";
            this.logToHistoryListActivity57.OtherData = "";
            this.logToHistoryListActivity57.UserId = -1;
            this.logToHistoryListActivity57.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind83)));
            this.logToHistoryListActivity57.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind82)));
            // 
            // ErrorHandler_Weryfikacja
            // 
            this.ErrorHandler_Weryfikacja.Name = "ErrorHandler_Weryfikacja";
            this.ErrorHandler_Weryfikacja.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // logToHistoryListActivity70
            // 
            this.logToHistoryListActivity70.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity70.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity70.HistoryDescription = "Weryfikacja_Null";
            this.logToHistoryListActivity70.HistoryOutcome = "";
            this.logToHistoryListActivity70.Name = "logToHistoryListActivity70";
            this.logToHistoryListActivity70.OtherData = "";
            this.logToHistoryListActivity70.UserId = -1;
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
            // logToHistoryListActivity84
            // 
            this.logToHistoryListActivity84.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity84.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind84.Name = "Workflow1";
            activitybind84.Path = "logErrorMessage_HistoryDescription";
            activitybind85.Name = "Workflow1";
            activitybind85.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity84.Name = "logToHistoryListActivity84";
            this.logToHistoryListActivity84.OtherData = "";
            this.logToHistoryListActivity84.UserId = -1;
            this.logToHistoryListActivity84.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind84)));
            this.logToHistoryListActivity84.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind85)));
            // 
            // codeActivity12
            // 
            this.codeActivity12.Name = "codeActivity12";
            this.codeActivity12.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
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
            // logToHistoryListActivity69
            // 
            this.logToHistoryListActivity69.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity69.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity69.HistoryDescription = "Wersja";
            this.logToHistoryListActivity69.HistoryOutcome = "1";
            this.logToHistoryListActivity69.Name = "logToHistoryListActivity69";
            this.logToHistoryListActivity69.OtherData = "";
            this.logToHistoryListActivity69.UserId = -1;
            // 
            // Navigator_Routing_ver2
            // 
            this.Navigator_Routing_ver2.Activities.Add(this.ifWeryfikacja);
            this.Navigator_Routing_ver2.Activities.Add(this.ifTelemarketing);
            this.Navigator_Routing_ver2.Activities.Add(this.ifOferta);
            this.Navigator_Routing_ver2.Activities.Add(this.ifOdrzucenie);
            this.Navigator_Routing_ver2.Activities.Add(this.ifAkceptacjaOferty);
            this.Navigator_Routing_ver2.Activities.Add(this.ifKorektaOferty);
            this.Navigator_Routing_ver2.Activities.Add(this.ifWniosek);
            this.Navigator_Routing_ver2.Activities.Add(this.ifAkceptacjaWniosku);
            this.Navigator_Routing_ver2.Activities.Add(this.ifKorektaWniosku);
            this.Navigator_Routing_ver2.Activities.Add(this.ifUmowa);
            this.Navigator_Routing_ver2.Activities.Add(this.ifAkceptacjaUmowy);
            this.Navigator_Routing_ver2.Activities.Add(this.ifUruchomienie);
            this.Navigator_Routing_ver2.Activities.Add(this.ifDokumentacja);
            this.Navigator_Routing_ver2.Activities.Add(this.ifRozliczenie);
            this.Navigator_Routing_ver2.Activities.Add(this.Else2);
            this.Navigator_Routing_ver2.Name = "Navigator_Routing_ver2";
            // 
            // logToHistoryListActivity68
            // 
            this.logToHistoryListActivity68.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity68.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity68.HistoryDescription = "Wersja";
            this.logToHistoryListActivity68.HistoryOutcome = "2";
            this.logToHistoryListActivity68.Name = "logToHistoryListActivity68";
            this.logToHistoryListActivity68.OtherData = "";
            this.logToHistoryListActivity68.UserId = -1;
            // 
            // logToHistoryListActivity83
            // 
            this.logToHistoryListActivity83.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity83.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind86.Name = "Workflow1";
            activitybind86.Path = "logErrorMessage_HistoryDescription";
            activitybind87.Name = "Workflow1";
            activitybind87.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity83.Name = "logToHistoryListActivity83";
            this.logToHistoryListActivity83.OtherData = "";
            this.logToHistoryListActivity83.UserId = -1;
            this.logToHistoryListActivity83.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind86)));
            this.logToHistoryListActivity83.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind87)));
            // 
            // codeActivity11
            // 
            this.codeActivity11.Name = "codeActivity11";
            this.codeActivity11.ExecuteCode += new System.EventHandler(this.ErrorHandler_ExecuteCode);
            // 
            // faultHandlerActivity2
            // 
            this.faultHandlerActivity2.Activities.Add(this.codeActivity26);
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
            // ifElseBranchActivity12
            // 
            this.ifElseBranchActivity12.Activities.Add(this.logToHistoryListActivity81);
            this.ifElseBranchActivity12.Name = "ifElseBranchActivity12";
            // 
            // Dokumentacja_Rozliczenie
            // 
            this.Dokumentacja_Rozliczenie.Activities.Add(this.logToHistoryListActivity54);
            this.Dokumentacja_Rozliczenie.Activities.Add(this.setStateActivity21);
            codecondition27.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsDokumentacja_Rozliczenie);
            this.Dokumentacja_Rozliczenie.Condition = codecondition27;
            this.Dokumentacja_Rozliczenie.Name = "Dokumentacja_Rozliczenie";
            // 
            // faultHandlerActivity28
            // 
            this.faultHandlerActivity28.Activities.Add(this.codeActivity25);
            this.faultHandlerActivity28.Activities.Add(this.logToHistoryListActivity97);
            this.faultHandlerActivity28.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity28.Name = "faultHandlerActivity28";
            // 
            // faultHandlerActivity14
            // 
            this.faultHandlerActivity14.Activities.Add(this.codeActivity9);
            this.faultHandlerActivity14.Activities.Add(this.logToHistoryListActivity66);
            this.faultHandlerActivity14.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity14.Name = "faultHandlerActivity14";
            // 
            // ifElseBranchActivity11
            // 
            this.ifElseBranchActivity11.Activities.Add(this.logToHistoryListActivity80);
            this.ifElseBranchActivity11.Name = "ifElseBranchActivity11";
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
            // faultHandlerActivity27
            // 
            this.faultHandlerActivity27.Activities.Add(this.codeActivity24);
            this.faultHandlerActivity27.Activities.Add(this.logToHistoryListActivity96);
            this.faultHandlerActivity27.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity27.Name = "faultHandlerActivity27";
            // 
            // faultHandlerActivity13
            // 
            this.faultHandlerActivity13.Activities.Add(this.codeActivity8);
            this.faultHandlerActivity13.Activities.Add(this.logToHistoryListActivity65);
            this.faultHandlerActivity13.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity13.Name = "faultHandlerActivity13";
            // 
            // ifElseBranchActivity10
            // 
            this.ifElseBranchActivity10.Activities.Add(this.logToHistoryListActivity79);
            this.ifElseBranchActivity10.Name = "ifElseBranchActivity10";
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
            // faultHandlerActivity26
            // 
            this.faultHandlerActivity26.Activities.Add(this.codeActivity23);
            this.faultHandlerActivity26.Activities.Add(this.logToHistoryListActivity95);
            this.faultHandlerActivity26.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity26.Name = "faultHandlerActivity26";
            // 
            // faultHandlerActivity12
            // 
            this.faultHandlerActivity12.Activities.Add(this.codeActivity7);
            this.faultHandlerActivity12.Activities.Add(this.logToHistoryListActivity64);
            this.faultHandlerActivity12.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity12.Name = "faultHandlerActivity12";
            // 
            // ifElseBranchActivity9
            // 
            this.ifElseBranchActivity9.Activities.Add(this.logToHistoryListActivity78);
            this.ifElseBranchActivity9.Name = "ifElseBranchActivity9";
            // 
            // Umowa_AkceptacjaUmowy
            // 
            this.Umowa_AkceptacjaUmowy.Activities.Add(this.logToHistoryListActivity45);
            this.Umowa_AkceptacjaUmowy.Activities.Add(this.setStateActivity19);
            codecondition32.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsUmowa_AkceptacjaUmowy);
            this.Umowa_AkceptacjaUmowy.Condition = codecondition32;
            this.Umowa_AkceptacjaUmowy.Name = "Umowa_AkceptacjaUmowy";
            // 
            // faultHandlerActivity25
            // 
            this.faultHandlerActivity25.Activities.Add(this.codeActivity22);
            this.faultHandlerActivity25.Activities.Add(this.logToHistoryListActivity94);
            this.faultHandlerActivity25.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity25.Name = "faultHandlerActivity25";
            // 
            // faultHandlerActivity11
            // 
            this.faultHandlerActivity11.Activities.Add(this.codeActivity6);
            this.faultHandlerActivity11.Activities.Add(this.logToHistoryListActivity63);
            this.faultHandlerActivity11.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity11.Name = "faultHandlerActivity11";
            // 
            // ifElseBranchActivity8
            // 
            this.ifElseBranchActivity8.Activities.Add(this.logToHistoryListActivity77);
            this.ifElseBranchActivity8.Name = "ifElseBranchActivity8";
            // 
            // KorektaWniosku_AkceptacjaWniosku
            // 
            this.KorektaWniosku_AkceptacjaWniosku.Activities.Add(this.logToHistoryListActivity43);
            this.KorektaWniosku_AkceptacjaWniosku.Activities.Add(this.setStateActivity17);
            codecondition33.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWniosek_AkceptacjaWniosku);
            this.KorektaWniosku_AkceptacjaWniosku.Condition = codecondition33;
            this.KorektaWniosku_AkceptacjaWniosku.Name = "KorektaWniosku_AkceptacjaWniosku";
            // 
            // faultHandlerActivity24
            // 
            this.faultHandlerActivity24.Activities.Add(this.codeActivity21);
            this.faultHandlerActivity24.Activities.Add(this.logToHistoryListActivity93);
            this.faultHandlerActivity24.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity24.Name = "faultHandlerActivity24";
            // 
            // faultHandlerActivity10
            // 
            this.faultHandlerActivity10.Activities.Add(this.codeActivity5);
            this.faultHandlerActivity10.Activities.Add(this.logToHistoryListActivity62);
            this.faultHandlerActivity10.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity10.Name = "faultHandlerActivity10";
            // 
            // ifElseBranchActivity7
            // 
            this.ifElseBranchActivity7.Activities.Add(this.logToHistoryListActivity76);
            this.ifElseBranchActivity7.Name = "ifElseBranchActivity7";
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
            // faultHandlerActivity23
            // 
            this.faultHandlerActivity23.Activities.Add(this.codeActivity20);
            this.faultHandlerActivity23.Activities.Add(this.logToHistoryListActivity92);
            this.faultHandlerActivity23.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity23.Name = "faultHandlerActivity23";
            // 
            // faultHandlerActivity9
            // 
            this.faultHandlerActivity9.Activities.Add(this.codeActivity4);
            this.faultHandlerActivity9.Activities.Add(this.logToHistoryListActivity61);
            this.faultHandlerActivity9.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity9.Name = "faultHandlerActivity9";
            // 
            // ifElseBranchActivity6
            // 
            this.ifElseBranchActivity6.Activities.Add(this.logToHistoryListActivity75);
            this.ifElseBranchActivity6.Name = "ifElseBranchActivity6";
            // 
            // Wniosek_AkceptacjaWniosku
            // 
            this.Wniosek_AkceptacjaWniosku.Activities.Add(this.logToHistoryListActivity27);
            this.Wniosek_AkceptacjaWniosku.Activities.Add(this.setStateActivity13);
            codecondition37.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWniosek_AkceptacjaWniosku);
            this.Wniosek_AkceptacjaWniosku.Condition = codecondition37;
            this.Wniosek_AkceptacjaWniosku.Name = "Wniosek_AkceptacjaWniosku";
            // 
            // faultHandlerActivity22
            // 
            this.faultHandlerActivity22.Activities.Add(this.codeActivity19);
            this.faultHandlerActivity22.Activities.Add(this.logToHistoryListActivity91);
            this.faultHandlerActivity22.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity22.Name = "faultHandlerActivity22";
            // 
            // faultHandlerActivity8
            // 
            this.faultHandlerActivity8.Activities.Add(this.codeActivity3);
            this.faultHandlerActivity8.Activities.Add(this.logToHistoryListActivity60);
            this.faultHandlerActivity8.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity8.Name = "faultHandlerActivity8";
            // 
            // ifElseBranchActivity5
            // 
            this.ifElseBranchActivity5.Activities.Add(this.logToHistoryListActivity74);
            this.ifElseBranchActivity5.Name = "ifElseBranchActivity5";
            // 
            // KorektaOferty_AkceptacjaOferty
            // 
            this.KorektaOferty_AkceptacjaOferty.Activities.Add(this.logToHistoryListActivity37);
            this.KorektaOferty_AkceptacjaOferty.Activities.Add(this.setStateActivity8);
            codecondition38.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.KorektaOferty_AkceptacjaOferty.Condition = codecondition38;
            this.KorektaOferty_AkceptacjaOferty.Name = "KorektaOferty_AkceptacjaOferty";
            // 
            // faultHandlerActivity21
            // 
            this.faultHandlerActivity21.Activities.Add(this.codeActivity18);
            this.faultHandlerActivity21.Activities.Add(this.logToHistoryListActivity90);
            this.faultHandlerActivity21.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity21.Name = "faultHandlerActivity21";
            // 
            // faultHandlerActivity1
            // 
            this.faultHandlerActivity1.Activities.Add(this.ErrorHandler);
            this.faultHandlerActivity1.Activities.Add(this.logErrorMessage);
            this.faultHandlerActivity1.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity1.Name = "faultHandlerActivity1";
            // 
            // ifElseBranchActivity4
            // 
            this.ifElseBranchActivity4.Activities.Add(this.logToHistoryListActivity73);
            this.ifElseBranchActivity4.Name = "ifElseBranchActivity4";
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
            // faultHandlerActivity20
            // 
            this.faultHandlerActivity20.Activities.Add(this.codeActivity17);
            this.faultHandlerActivity20.Activities.Add(this.logToHistoryListActivity89);
            this.faultHandlerActivity20.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity20.Name = "faultHandlerActivity20";
            // 
            // faultHandlerActivity19
            // 
            this.faultHandlerActivity19.Activities.Add(this.codeActivity16);
            this.faultHandlerActivity19.Activities.Add(this.logToHistoryListActivity88);
            this.faultHandlerActivity19.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity19.Name = "faultHandlerActivity19";
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
            // ifElseBranchActivity3
            // 
            this.ifElseBranchActivity3.Activities.Add(this.logToHistoryListActivity72);
            this.ifElseBranchActivity3.Name = "ifElseBranchActivity3";
            // 
            // Oferta_AkceptacjaOferty
            // 
            this.Oferta_AkceptacjaOferty.Activities.Add(this.setStateActivity5);
            codecondition44.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.Oferta_AkceptacjaOferty.Condition = codecondition44;
            this.Oferta_AkceptacjaOferty.Name = "Oferta_AkceptacjaOferty";
            // 
            // faultHandlerActivity18
            // 
            this.faultHandlerActivity18.Activities.Add(this.codeActivity15);
            this.faultHandlerActivity18.Activities.Add(this.logToHistoryListActivity87);
            this.faultHandlerActivity18.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity18.Name = "faultHandlerActivity18";
            // 
            // faultHandlerActivity6
            // 
            this.faultHandlerActivity6.Activities.Add(this.codeActivity1);
            this.faultHandlerActivity6.Activities.Add(this.logToHistoryListActivity58);
            this.faultHandlerActivity6.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity6.Name = "faultHandlerActivity6";
            // 
            // ifElseBranchActivity2
            // 
            this.ifElseBranchActivity2.Activities.Add(this.logToHistoryListActivity71);
            this.ifElseBranchActivity2.Name = "ifElseBranchActivity2";
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
            // faultHandlerActivity17
            // 
            this.faultHandlerActivity17.Activities.Add(this.codeActivity14);
            this.faultHandlerActivity17.Activities.Add(this.logToHistoryListActivity86);
            this.faultHandlerActivity17.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity17.Name = "faultHandlerActivity17";
            // 
            // faultHandlerActivity4
            // 
            this.faultHandlerActivity4.Activities.Add(this.codeActivity13);
            this.faultHandlerActivity4.Activities.Add(this.logToHistoryListActivity85);
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
            // ifElseBranchActivity1
            // 
            this.ifElseBranchActivity1.Activities.Add(this.logToHistoryListActivity70);
            this.ifElseBranchActivity1.Name = "ifElseBranchActivity1";
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
            this.faultHandlerActivity3.Activities.Add(this.codeActivity12);
            this.faultHandlerActivity3.Activities.Add(this.logToHistoryListActivity84);
            this.faultHandlerActivity3.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity3.Name = "faultHandlerActivity3";
            // 
            // Else
            // 
            this.Else.Activities.Add(this.logToHistoryListActivity69);
            this.Else.Activities.Add(this.Navigator_Routing);
            this.Else.Name = "Else";
            // 
            // ifEtapNotNull
            // 
            this.ifEtapNotNull.Activities.Add(this.logToHistoryListActivity68);
            this.ifEtapNotNull.Activities.Add(this.Navigator_Routing_ver2);
            codecondition50.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isEtapNotNull);
            this.ifEtapNotNull.Condition = codecondition50;
            this.ifEtapNotNull.Name = "ifEtapNotNull";
            // 
            // faultHandlerActivity16
            // 
            this.faultHandlerActivity16.Activities.Add(this.codeActivity11);
            this.faultHandlerActivity16.Activities.Add(this.logToHistoryListActivity83);
            this.faultHandlerActivity16.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity16.Name = "faultHandlerActivity16";
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
            activitybind88.Name = "Workflow1";
            activitybind88.Path = "logRozliczenie_DodajDoRozliczen";
            this.logToHistoryListActivity3.HistoryOutcome = "";
            this.logToHistoryListActivity3.Name = "logToHistoryListActivity3";
            this.logToHistoryListActivity3.OtherData = "";
            this.logToHistoryListActivity3.UserId = -1;
            this.logToHistoryListActivity3.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind88)));
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
            this.setState_Rozliczenie.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity11.Activities.Add(this.ifElseBranchActivity12);
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
            correlationtoken3.Name = "wtDokumentacja";
            correlationtoken3.OwnerActivityName = "Dokumentacja";
            this.onWorkflowItemChanged11.CorrelationToken = correlationtoken3;
            this.onWorkflowItemChanged11.Name = "onWorkflowItemChanged11";
            // 
            // faultHandlersActivity29
            // 
            this.faultHandlersActivity29.Activities.Add(this.faultHandlerActivity28);
            this.faultHandlersActivity29.Name = "faultHandlersActivity29";
            // 
            // initializeWorkflow12
            // 
            this.initializeWorkflow12.CorrelationToken = correlationtoken3;
            this.initializeWorkflow12.Name = "initializeWorkflow12";
            // 
            // setState_Dokumentacja
            // 
            this.setState_Dokumentacja.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity123.Activities.Add(this.ifElseBranchActivity11);
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
            correlationtoken4.Name = "wtUruchomienie";
            correlationtoken4.OwnerActivityName = "Uruchomienie";
            this.onWorkflowItemChanged12.CorrelationToken = correlationtoken4;
            this.onWorkflowItemChanged12.Name = "onWorkflowItemChanged12";
            // 
            // faultHandlersActivity28
            // 
            this.faultHandlersActivity28.Activities.Add(this.faultHandlerActivity27);
            this.faultHandlersActivity28.Name = "faultHandlersActivity28";
            // 
            // initializeWorkflow11
            // 
            this.initializeWorkflow11.CorrelationToken = correlationtoken4;
            this.initializeWorkflow11.Name = "initializeWorkflow11";
            // 
            // setState_Uruchomienie
            // 
            this.setState_Uruchomienie.CorrelationToken = correlationtoken2;
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
            this.TestAkceptacjaUmowy.Activities.Add(this.ifElseBranchActivity10);
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
            correlationtoken5.Name = "wtAkceptacjaUmowy";
            correlationtoken5.OwnerActivityName = "AkceptacjaUmowy";
            this.onWorkflowItemChanged10.CorrelationToken = correlationtoken5;
            this.onWorkflowItemChanged10.Name = "onWorkflowItemChanged10";
            // 
            // faultHandlersActivity27
            // 
            this.faultHandlersActivity27.Activities.Add(this.faultHandlerActivity26);
            this.faultHandlersActivity27.Name = "faultHandlersActivity27";
            // 
            // initializeWorkflow10
            // 
            this.initializeWorkflow10.CorrelationToken = correlationtoken5;
            this.initializeWorkflow10.Name = "initializeWorkflow10";
            // 
            // setState_AkceptacjaUmowy
            // 
            this.setState_AkceptacjaUmowy.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity9.Activities.Add(this.ifElseBranchActivity9);
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
            // Update_Item
            // 
            this.Update_Item.Name = "Update_Item";
            this.Update_Item.ExecuteCode += new System.EventHandler(this.Update_Item_ExecuteCode);
            // 
            // onWorkflowItemChanged9
            // 
            this.onWorkflowItemChanged9.AfterProperties = null;
            this.onWorkflowItemChanged9.BeforeProperties = null;
            correlationtoken6.Name = "wtUmowa";
            correlationtoken6.OwnerActivityName = "Umowa";
            this.onWorkflowItemChanged9.CorrelationToken = correlationtoken6;
            this.onWorkflowItemChanged9.Name = "onWorkflowItemChanged9";
            // 
            // faultHandlersActivity26
            // 
            this.faultHandlersActivity26.Activities.Add(this.faultHandlerActivity25);
            this.faultHandlersActivity26.Name = "faultHandlersActivity26";
            // 
            // initializeWorkflow9
            // 
            this.initializeWorkflow9.CorrelationToken = correlationtoken6;
            this.initializeWorkflow9.Name = "initializeWorkflow9";
            // 
            // setState_Umowa
            // 
            this.setState_Umowa.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity8.Activities.Add(this.ifElseBranchActivity8);
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
            correlationtoken7.Name = "wtKorektaWniosku";
            correlationtoken7.OwnerActivityName = "KorektaWniosku";
            this.onWorkflowItemChanged8.CorrelationToken = correlationtoken7;
            this.onWorkflowItemChanged8.Name = "onWorkflowItemChanged8";
            // 
            // faultHandlersActivity30
            // 
            this.faultHandlersActivity30.Activities.Add(this.faultHandlerActivity24);
            this.faultHandlersActivity30.Name = "faultHandlersActivity30";
            // 
            // initializeWorkflow8
            // 
            this.initializeWorkflow8.CorrelationToken = correlationtoken7;
            this.initializeWorkflow8.Name = "initializeWorkflow8";
            // 
            // setState_KorektaWniosku
            // 
            this.setState_KorektaWniosku.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity7.Activities.Add(this.ifElseBranchActivity7);
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
            correlationtoken8.Name = "wtAkceptacjaWniosku";
            correlationtoken8.OwnerActivityName = "AkceptacjaWniosku";
            this.onWorkflowItemChanged7.CorrelationToken = correlationtoken8;
            this.onWorkflowItemChanged7.Name = "onWorkflowItemChanged7";
            // 
            // faultHandlersActivity25
            // 
            this.faultHandlersActivity25.Activities.Add(this.faultHandlerActivity23);
            this.faultHandlersActivity25.Name = "faultHandlersActivity25";
            // 
            // initializeWorkflow7
            // 
            this.initializeWorkflow7.CorrelationToken = correlationtoken8;
            this.initializeWorkflow7.Name = "initializeWorkflow7";
            // 
            // setState_AkceptacjaWniosku
            // 
            this.setState_AkceptacjaWniosku.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity6.Activities.Add(this.ifElseBranchActivity6);
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
            correlationtoken9.Name = "wtWniosek";
            correlationtoken9.OwnerActivityName = "Wniosek";
            this.onWorkflowItemChanged6.CorrelationToken = correlationtoken9;
            this.onWorkflowItemChanged6.Name = "onWorkflowItemChanged6";
            // 
            // faultHandlersActivity24
            // 
            this.faultHandlersActivity24.Activities.Add(this.faultHandlerActivity22);
            this.faultHandlersActivity24.Name = "faultHandlersActivity24";
            // 
            // initializeWorkflow6
            // 
            this.initializeWorkflow6.CorrelationToken = correlationtoken9;
            this.initializeWorkflow6.Name = "initializeWorkflow6";
            // 
            // codeDodajDoRozliczen
            // 
            this.codeDodajDoRozliczen.Name = "codeDodajDoRozliczen";
            this.codeDodajDoRozliczen.ExecuteCode += new System.EventHandler(this.codeDodajDoRozliczen_ExecuteCode);
            // 
            // setState_Wniosek
            // 
            this.setState_Wniosek.CorrelationToken = correlationtoken2;
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
            this.ifElseActivity5.Activities.Add(this.ifElseBranchActivity5);
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
            correlationtoken10.Name = "wtKorektaOferty";
            correlationtoken10.OwnerActivityName = "KorektaOferty";
            this.onWorkflowItemChanged5.CorrelationToken = correlationtoken10;
            this.onWorkflowItemChanged5.Name = "onWorkflowItemChanged5";
            // 
            // faultHandlersActivity23
            // 
            this.faultHandlersActivity23.Activities.Add(this.faultHandlerActivity21);
            this.faultHandlersActivity23.Name = "faultHandlersActivity23";
            // 
            // initializeWorkflow5
            // 
            this.initializeWorkflow5.CorrelationToken = correlationtoken10;
            this.initializeWorkflow5.Name = "initializeWorkflow5";
            // 
            // setState_KorektaOferty
            // 
            this.setState_KorektaOferty.CorrelationToken = correlationtoken2;
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
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.ifElseBranchActivity4);
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
            correlationtoken11.Name = "wtAkceptacjaOferty";
            correlationtoken11.OwnerActivityName = "AkceptacjaOferty";
            this.onWorkflowItemChanged4.CorrelationToken = correlationtoken11;
            this.onWorkflowItemChanged4.Name = "onWorkflowItemChanged4";
            // 
            // faultHandlersActivity22
            // 
            this.faultHandlersActivity22.Activities.Add(this.faultHandlerActivity20);
            this.faultHandlersActivity22.Name = "faultHandlersActivity22";
            // 
            // initializeWorkflow4
            // 
            this.initializeWorkflow4.CorrelationToken = correlationtoken11;
            this.initializeWorkflow4.Name = "initializeWorkflow4";
            // 
            // setState_AkceptacjaOferty
            // 
            this.setState_AkceptacjaOferty.CorrelationToken = correlationtoken2;
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
            // faultHandlersActivity21
            // 
            this.faultHandlersActivity21.Activities.Add(this.faultHandlerActivity19);
            this.faultHandlersActivity21.Name = "faultHandlersActivity21";
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
            this.setState_Odrzucony.CorrelationToken = correlationtoken2;
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
            this.Oferta_Routing.Activities.Add(this.ifElseBranchActivity3);
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
            correlationtoken12.Name = "wtOferta";
            correlationtoken12.OwnerActivityName = "Oferta";
            this.onWorkflowItemChanged2.CorrelationToken = correlationtoken12;
            this.onWorkflowItemChanged2.Name = "onWorkflowItemChanged2";
            // 
            // faultHandlersActivity20
            // 
            this.faultHandlersActivity20.Activities.Add(this.faultHandlerActivity18);
            this.faultHandlersActivity20.Name = "faultHandlersActivity20";
            // 
            // initializeWorkflow3
            // 
            this.initializeWorkflow3.CorrelationToken = correlationtoken12;
            this.initializeWorkflow3.Name = "initializeWorkflow3";
            // 
            // setState_Oferta
            // 
            this.setState_Oferta.CorrelationToken = correlationtoken2;
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
            this.Telemarketing_Routing.Activities.Add(this.ifElseBranchActivity2);
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
            correlationtoken13.Name = "wtTelemarketing";
            correlationtoken13.OwnerActivityName = "Telemarketing";
            this.onWorkflowItemChanged3.CorrelationToken = correlationtoken13;
            this.onWorkflowItemChanged3.Name = "onWorkflowItemChanged3";
            // 
            // faultHandlersActivity19
            // 
            this.faultHandlersActivity19.Activities.Add(this.faultHandlerActivity17);
            this.faultHandlersActivity19.Name = "faultHandlersActivity19";
            // 
            // initializeWorkflow2
            // 
            this.initializeWorkflow2.CorrelationToken = correlationtoken13;
            this.initializeWorkflow2.Name = "initializeWorkflow2";
            // 
            // setState_Telemarketing
            // 
            this.setState_Telemarketing.CorrelationToken = correlationtoken2;
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
            correlationtoken14.Name = "wtWeryfikacja";
            correlationtoken14.OwnerActivityName = "Weryfikacja";
            this.initializeWorkflow1.CorrelationToken = correlationtoken14;
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
            this.setState_Weryfikacja.CorrelationToken = correlationtoken2;
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
            this.Weryfikacja_Routing.Activities.Add(this.ifElseBranchActivity1);
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
            this.onWorkflowItemChanged13.CorrelationToken = correlationtoken14;
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
            this.faultHandlersActivity1.Activities.Add(this.faultHandlerActivity16);
            this.faultHandlersActivity1.Name = "faultHandlersActivity1";
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "Navigator";
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
            // onWorkflowActivated2
            // 
            correlationtoken15.Name = "myToken";
            correlationtoken15.OwnerActivityName = "Workflow1";
            this.onWorkflowActivated2.CorrelationToken = correlationtoken15;
            this.onWorkflowActivated2.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated2.Name = "onWorkflowActivated2";
            activitybind89.Name = "Workflow1";
            activitybind89.Path = "workflowProperties";
            this.onWorkflowActivated2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind89)));
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
            this.stateInitializationActivity10.Activities.Add(this.faultHandlersActivity29);
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
            this.stateInitializationActivity11.Activities.Add(this.faultHandlersActivity28);
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
            this.stateInitializationActivity14.Activities.Add(this.faultHandlersActivity27);
            this.stateInitializationActivity14.Name = "stateInitializationActivity14";
            // 
            // Umowa_OnChange
            // 
            this.Umowa_OnChange.Activities.Add(this.onWorkflowItemChanged9);
            this.Umowa_OnChange.Activities.Add(this.Update_Item);
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
            this.stateInitializationActivity9.Activities.Add(this.faultHandlersActivity26);
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
            this.stateInitializationActivity13.Activities.Add(this.faultHandlersActivity30);
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
            this.stateInitializationActivity8.Activities.Add(this.faultHandlersActivity25);
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
            this.stateInitializationActivity7.Activities.Add(this.codeDodajDoRozliczen);
            this.stateInitializationActivity7.Activities.Add(this.initializeWorkflow6);
            this.stateInitializationActivity7.Activities.Add(this.faultHandlersActivity24);
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
            this.stateInitializationActivity6.Activities.Add(this.faultHandlersActivity23);
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
            this.stateInitializationActivity5.Activities.Add(this.faultHandlersActivity22);
            this.stateInitializationActivity5.Name = "stateInitializationActivity5";
            // 
            // stateInitializationActivity2
            // 
            this.stateInitializationActivity2.Activities.Add(this.setState_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.SetCT_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.logToHistoryListActivity2);
            this.stateInitializationActivity2.Activities.Add(this.ifElseActivity1);
            this.stateInitializationActivity2.Activities.Add(this.setStateActivity26);
            this.stateInitializationActivity2.Activities.Add(this.faultHandlersActivity21);
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
            this.stateInitializationActivity4.Activities.Add(this.faultHandlersActivity20);
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
            this.stateInitializationActivity3.Activities.Add(this.faultHandlersActivity19);
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
            this.eventDrivenActivity1.Activities.Add(this.onWorkflowActivated2);
            this.eventDrivenActivity1.Activities.Add(this.logZainicjowany);
            this.eventDrivenActivity1.Activities.Add(this.codeSetup);
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

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity87;

        private CodeActivity codeActivity15;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity86;

        private CodeActivity codeActivity14;

        private FaultHandlerActivity faultHandlerActivity18;

        private FaultHandlerActivity faultHandlerActivity17;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity90;

        private CodeActivity codeActivity18;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity89;

        private CodeActivity codeActivity17;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity88;

        private CodeActivity codeActivity16;

        private FaultHandlerActivity faultHandlerActivity21;

        private FaultHandlerActivity faultHandlerActivity20;

        private FaultHandlerActivity faultHandlerActivity19;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity93;

        private CodeActivity codeActivity21;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity92;

        private CodeActivity codeActivity20;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity91;

        private CodeActivity codeActivity19;

        private FaultHandlerActivity faultHandlerActivity24;

        private FaultHandlerActivity faultHandlerActivity23;

        private FaultHandlerActivity faultHandlerActivity22;

        private FaultHandlersActivity faultHandlersActivity30;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity4;

        private CodeActivity codeActivity26;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity97;

        private CodeActivity codeActivity25;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity96;

        private CodeActivity codeActivity24;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity95;

        private CodeActivity codeActivity23;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity94;

        private CodeActivity codeActivity22;

        private FaultHandlerActivity faultHandlerActivity2;

        private FaultHandlerActivity faultHandlerActivity28;

        private FaultHandlerActivity faultHandlerActivity27;

        private FaultHandlerActivity faultHandlerActivity26;

        private FaultHandlerActivity faultHandlerActivity25;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow1;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow2;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow3;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow4;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow5;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow7;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow6;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow8;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow10;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow9;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow11;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow12;

        private FaultHandlersActivity faultHandlersActivity29;

        private FaultHandlersActivity faultHandlersActivity28;

        private FaultHandlersActivity faultHandlersActivity27;

        private FaultHandlersActivity faultHandlersActivity26;

        private FaultHandlersActivity faultHandlersActivity25;

        private FaultHandlersActivity faultHandlersActivity24;

        private FaultHandlersActivity faultHandlersActivity23;

        private FaultHandlersActivity faultHandlersActivity22;

        private FaultHandlersActivity faultHandlersActivity21;

        private FaultHandlersActivity faultHandlersActivity20;

        private FaultHandlersActivity faultHandlersActivity19;

        private SetStateActivity setStateActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity84;

        private CodeActivity codeActivity12;

        private FaultHandlerActivity faultHandlerActivity3;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity85;

        private CodeActivity codeActivity13;

        private FaultHandlerActivity faultHandlerActivity4;

        private FaultHandlersActivity faultHandlersActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity83;

        private CodeActivity codeActivity11;

        private FaultHandlerActivity faultHandlerActivity16;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated2;

        private CodeActivity Update_Item;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity81;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity80;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity79;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity78;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity77;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity76;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity75;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity74;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity73;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity72;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity71;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity70;

        private IfElseBranchActivity ifElseBranchActivity12;

        private IfElseBranchActivity ifElseBranchActivity11;

        private IfElseBranchActivity ifElseBranchActivity10;

        private IfElseBranchActivity ifElseBranchActivity9;

        private IfElseBranchActivity ifElseBranchActivity8;

        private IfElseBranchActivity ifElseBranchActivity7;

        private IfElseBranchActivity ifElseBranchActivity6;

        private IfElseBranchActivity ifElseBranchActivity5;

        private IfElseBranchActivity ifElseBranchActivity4;

        private IfElseBranchActivity ifElseBranchActivity3;

        private IfElseBranchActivity ifElseBranchActivity2;

        private IfElseBranchActivity ifElseBranchActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity69;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity68;

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

        private IfElseActivity Navigator_Routing_ver2;

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

        private SetStateActivity setStateActivity2;

        private CodeActivity StatusRozmowa_Stracony;

        private SetStateActivity setStateActivity4;

        private CodeActivity StatusRozmowa_Telefon;

        private SetStateActivity setStateActivity3;

        private CodeActivity StatusRozmowa_Oferta;

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

        private FaultHandlerActivity faultHandlerActivity5;

        private FaultHandlersActivity faultHandlersActivity6;

        private IfElseBranchActivity Weryfikacja_Odrzucenie;

        private IfElseBranchActivity Weryfikacja_Telemarketing;

        private IfElseBranchActivity Weryfikacja_Oferta;

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

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logZainicjowany;

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
