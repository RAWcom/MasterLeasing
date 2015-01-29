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
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind25 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind26 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind27 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind28 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind29 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind30 = new System.Workflow.ComponentModel.ActivityBind();
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
            System.Workflow.Activities.CodeCondition codecondition27 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition28 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition29 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition30 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition31 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition32 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition33 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition34 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition35 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind31 = new System.Workflow.ComponentModel.ActivityBind();
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
            System.Workflow.ComponentModel.ActivityBind activitybind32 = new System.Workflow.ComponentModel.ActivityBind();
            this.logToHistoryListActivity20 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_Uruchomiony = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity19 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_UmowaZaakceptowana = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity18 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_WniosekZaakceptowany = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_OfertaZaakceptowana = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.Uruchomiony_SendMailAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_SendEmailAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_SendMailAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_MailSendAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.logToHistoryListActivity4 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity21 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity22 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity10 = new System.Workflow.Activities.IfElseActivity();
            this.setStateActivity18 = new System.Workflow.Activities.SetStateActivity();
            this.StatusUmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_UmowaNiezaakceptowana = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity24 = new System.Workflow.Activities.SetStateActivity();
            this.StatusUmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_UmowaStracona = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity20 = new System.Workflow.Activities.SetStateActivity();
            this.StatusUmowa_Uruchomienie = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity4 = new System.Workflow.Activities.IfElseActivity();
            this.Komunikat_UmowaUruchomiona = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity19 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity17 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity16 = new System.Workflow.Activities.SetStateActivity();
            this.StatusWniosek_Stracony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_WniosekOdrzucony = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity15 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity14 = new System.Workflow.Activities.SetStateActivity();
            this.StatusWniosek_Umowa = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity3 = new System.Workflow.Activities.IfElseActivity();
            this.Komunikat_AkceptacjaWniosku = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity13 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity8 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity7 = new System.Workflow.Activities.SetStateActivity();
            this.StatusOferta_Telefon = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity6 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity12 = new System.Workflow.Activities.SetStateActivity();
            this.StatusOferta_Stracony = new System.Workflow.Activities.CodeActivity();
            this.Komunikat_OfertaNiezaakceptowana = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity11 = new System.Workflow.Activities.SetStateActivity();
            this.StatusOferta_Wniosek = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.Komunikat_AkceptacjaOferty = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity17 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_Stracony = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.setStateActivity5 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity10 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Stracony = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity9 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logERROR_WefyfikacjaInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logERROR_WefyfikacjaEvent = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Oferta = new System.Workflow.Activities.CodeActivity();
            this.logERROR_NavigatorInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity27 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity23 = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Stracony = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Uruchomienie = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Umowa = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Wniosek = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Oferta = new System.Workflow.Activities.SetStateActivity();
            this.Navigator_Telemarketing = new System.Workflow.Activities.SetStateActivity();
            this.faultHandlerActivity2 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Dokumentacja_Rozliczenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Uruchomienie_Dokumentacja = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaUmowy_Uruchomienie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Umowa_AkceptacjaUmowy = new System.Workflow.Activities.IfElseBranchActivity();
            this.KorektaWniosku_AkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_KorektaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaWniosku_Umowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.Wniosek_AkceptacjaWniosku = new System.Workflow.Activities.IfElseBranchActivity();
            this.KorektaOferty_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Telemarketing1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_KorektaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.AkceptacjaOferty_Wniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.Odrzucenie_MailSendAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.Oferta_AkceptacjaOferty = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity4 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity5 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlersActivity6 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity3 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Status_Lead_Else = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Rozliczenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlersActivity7 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.StatusLeadu_Stracony = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Uruchomiony = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Umowa = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Wniosek = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Oferta = new System.Workflow.Activities.IfElseBranchActivity();
            this.StatusLeadu_Telefon = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlersActivity2 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity25 = new System.Workflow.Activities.SetStateActivity();
            this.logToHistoryListActivity3 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.nRozliczenie_DodajDoRozliczen = new System.Workflow.Activities.CodeActivity();
            this.SetCT_Rozliczenie = new System.Workflow.Activities.CodeActivity();
            this.setState_Rozliczenie = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity11 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity11 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged11 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Dokumentacja = new System.Workflow.Activities.CodeActivity();
            this.setState_Dokumentacja = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity9 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity123 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged12 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Uruchomienie = new System.Workflow.Activities.CodeActivity();
            this.setState_Uruchomienie = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity10 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.TestAkceptacjaUmowy = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged10 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_AkceptacjaUmowy = new System.Workflow.Activities.CodeActivity();
            this.setState_AkceptacjaUmowy = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity13 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity9 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged9 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Umowa = new System.Workflow.Activities.CodeActivity();
            this.setState_Umowa = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity8 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity8 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged8 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Wniosek1 = new System.Workflow.Activities.CodeActivity();
            this.setState_KorektaWniosku = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity12 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity7 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged7 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_AkceptacjaWniosku = new System.Workflow.Activities.CodeActivity();
            this.setState_AkceptacjaWniosku = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity7 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity6 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged6 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.codeDodajDoRozliczen = new System.Workflow.Activities.CodeActivity();
            this.SetCT_Wniosek = new System.Workflow.Activities.CodeActivity();
            this.setState_Wniosek = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity6 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ifElseActivity5 = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged5 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Oferta1 = new System.Workflow.Activities.CodeActivity();
            this.setState_KorektaOferty = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logKorektaOferty = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.AkceptacjaOferty_Telemarketing = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged4 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_AkceptacjaOferty = new System.Workflow.Activities.CodeActivity();
            this.setState_AkceptacjaOferty = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity5 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity26 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity2 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Odrzucony = new System.Workflow.Activities.CodeActivity();
            this.setState_Odrzucony = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.Oferta_Routing = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged2 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Oferta = new System.Workflow.Activities.CodeActivity();
            this.setState_Oferta = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity15 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Telemarketing_Routing = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged3 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.SetCT_Telemarketing = new System.Workflow.Activities.CodeActivity();
            this.setState_Telemarketing = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.logToHistoryListActivity16 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.faultHandlersActivity4 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.SetCT_Weryfikacja = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity14 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setState_Weryfikacja = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.faultHandlersActivity5 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Routing = new System.Workflow.Activities.IfElseActivity();
            this.onWorkflowItemChanged13 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity3 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Navigator_Routing = new System.Workflow.Activities.IfElseActivity();
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
            correlationtoken1.OwnerActivityName = "Workflow1";
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
            correlationtoken3.Name = "myWorkflowToken";
            correlationtoken3.OwnerActivityName = "Workflow1";
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
            correlationtoken4.OwnerActivityName = "Workflow1";
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
            // Uruchomiony_SendMailAllowed
            // 
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
            this.AkceptacjaWniosku_SendMailAllowed.Activities.Add(this.sendEmail_WniosekZaakceptowany);
            this.AkceptacjaWniosku_SendMailAllowed.Activities.Add(this.logToHistoryListActivity18);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_SendMailAllowed);
            this.AkceptacjaWniosku_SendMailAllowed.Condition = codecondition3;
            this.AkceptacjaWniosku_SendMailAllowed.Name = "AkceptacjaWniosku_SendMailAllowed";
            // 
            // AkceptacjaOferty_MailSendAllowed
            // 
            this.AkceptacjaOferty_MailSendAllowed.Activities.Add(this.sendEmail_OfertaZaakceptowana);
            this.AkceptacjaOferty_MailSendAllowed.Activities.Add(this.logToHistoryListActivity1);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_MailSendAllowed);
            this.AkceptacjaOferty_MailSendAllowed.Condition = codecondition4;
            this.AkceptacjaOferty_MailSendAllowed.Name = "AkceptacjaOferty_MailSendAllowed";
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
            // setStateActivity21
            // 
            this.setStateActivity21.Name = "setStateActivity21";
            this.setStateActivity21.TargetStateName = "Rozliczenie";
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
            // setStateActivity19
            // 
            this.setStateActivity19.Name = "setStateActivity19";
            this.setStateActivity19.TargetStateName = "AkceptacjaUmowy";
            // 
            // setStateActivity17
            // 
            this.setStateActivity17.Name = "setStateActivity17";
            this.setStateActivity17.TargetStateName = "AkceptacjaWniosku";
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
            // setStateActivity15
            // 
            this.setStateActivity15.Name = "setStateActivity15";
            this.setStateActivity15.TargetStateName = "KorektaWniosku";
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
            // setStateActivity13
            // 
            this.setStateActivity13.Name = "setStateActivity13";
            this.setStateActivity13.TargetStateName = "AkceptacjaWniosku";
            // 
            // setStateActivity8
            // 
            this.setStateActivity8.Name = "setStateActivity8";
            this.setStateActivity8.TargetStateName = "AkceptacjaOferty";
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
            // setStateActivity6
            // 
            this.setStateActivity6.Name = "setStateActivity6";
            this.setStateActivity6.TargetStateName = "KorektaOferty";
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
            activitybind25.Name = "Workflow1";
            activitybind25.Path = "Mail_BCC";
            activitybind26.Name = "Workflow1";
            activitybind26.Path = "Mail_Body";
            activitybind27.Name = "Workflow1";
            activitybind27.Path = "Mail_CC";
            correlationtoken5.Name = "myWorkflowToken";
            correlationtoken5.OwnerActivityName = "Workflow1";
            this.sendEmail_Stracony.CorrelationToken = correlationtoken5;
            activitybind28.Name = "Workflow1";
            activitybind28.Path = "Mail_From";
            this.sendEmail_Stracony.Headers = null;
            this.sendEmail_Stracony.IncludeStatus = false;
            this.sendEmail_Stracony.Name = "sendEmail_Stracony";
            activitybind29.Name = "Workflow1";
            activitybind29.Path = "Mail_Subject";
            activitybind30.Name = "Workflow1";
            activitybind30.Path = "Mail_To";
            this.sendEmail_Stracony.MethodInvoking += new System.EventHandler(this.sendEmail_Stracony_MethodInvoking);
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind30)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind29)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind26)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind25)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind27)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind28)));
            // 
            // setStateActivity5
            // 
            this.setStateActivity5.Name = "setStateActivity5";
            this.setStateActivity5.TargetStateName = "AkceptacjaOferty";
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
            // logERROR_WefyfikacjaEvent
            // 
            this.logERROR_WefyfikacjaEvent.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logERROR_WefyfikacjaEvent.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logERROR_WefyfikacjaEvent.HistoryDescription = "WeryfikacjaEvent";
            this.logERROR_WefyfikacjaEvent.HistoryOutcome = "ERR";
            this.logERROR_WefyfikacjaEvent.Name = "logERROR_WefyfikacjaEvent";
            this.logERROR_WefyfikacjaEvent.OtherData = "";
            this.logERROR_WefyfikacjaEvent.UserId = -1;
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
            // faultHandlerActivity2
            // 
            this.faultHandlerActivity2.Activities.Add(this.logToHistoryListActivity4);
            this.faultHandlerActivity2.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity2.Name = "faultHandlerActivity2";
            // 
            // Dokumentacja_Rozliczenie
            // 
            this.Dokumentacja_Rozliczenie.Activities.Add(this.setStateActivity21);
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsDokumentacja_Rozliczenie);
            this.Dokumentacja_Rozliczenie.Condition = codecondition5;
            this.Dokumentacja_Rozliczenie.Name = "Dokumentacja_Rozliczenie";
            // 
            // Uruchomienie_Dokumentacja
            // 
            this.Uruchomienie_Dokumentacja.Activities.Add(this.ifElseActivity10);
            this.Uruchomienie_Dokumentacja.Activities.Add(this.setStateActivity22);
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsUruchomienie_Dokumentacja);
            this.Uruchomienie_Dokumentacja.Condition = codecondition6;
            this.Uruchomienie_Dokumentacja.Name = "Uruchomienie_Dokumentacja";
            // 
            // AkceptacjaUmowy_Telemarketing
            // 
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.Komunikat_UmowaNiezaakceptowana);
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.StatusUmowa_Telefon);
            this.AkceptacjaUmowy_Telemarketing.Activities.Add(this.setStateActivity18);
            codecondition7.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_Telemarketing);
            this.AkceptacjaUmowy_Telemarketing.Condition = codecondition7;
            this.AkceptacjaUmowy_Telemarketing.Name = "AkceptacjaUmowy_Telemarketing";
            // 
            // AkceptacjaUmowy_Odrzucenie
            // 
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.Komunikat_UmowaStracona);
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.StatusUmowa_Stracony);
            this.AkceptacjaUmowy_Odrzucenie.Activities.Add(this.setStateActivity24);
            codecondition8.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_Odrzucenie);
            this.AkceptacjaUmowy_Odrzucenie.Condition = codecondition8;
            this.AkceptacjaUmowy_Odrzucenie.Name = "AkceptacjaUmowy_Odrzucenie";
            // 
            // AkceptacjaUmowy_Uruchomienie
            // 
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.Komunikat_UmowaUruchomiona);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.ifElseActivity4);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.StatusUmowa_Uruchomienie);
            this.AkceptacjaUmowy_Uruchomienie.Activities.Add(this.setStateActivity20);
            codecondition9.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaUmowy_Uruchomienie);
            this.AkceptacjaUmowy_Uruchomienie.Condition = codecondition9;
            this.AkceptacjaUmowy_Uruchomienie.Name = "AkceptacjaUmowy_Uruchomienie";
            // 
            // Umowa_AkceptacjaUmowy
            // 
            this.Umowa_AkceptacjaUmowy.Activities.Add(this.setStateActivity19);
            codecondition10.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsUmowa_AkceptacjaUmowy);
            this.Umowa_AkceptacjaUmowy.Condition = codecondition10;
            this.Umowa_AkceptacjaUmowy.Name = "Umowa_AkceptacjaUmowy";
            // 
            // KorektaWniosku_AkceptacjaWniosku
            // 
            this.KorektaWniosku_AkceptacjaWniosku.Activities.Add(this.setStateActivity17);
            codecondition11.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWniosek_AkceptacjaWniosku);
            this.KorektaWniosku_AkceptacjaWniosku.Condition = codecondition11;
            this.KorektaWniosku_AkceptacjaWniosku.Name = "KorektaWniosku_AkceptacjaWniosku";
            // 
            // AkceptacjaWniosku_Odrzucenie
            // 
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.Komunikat_WniosekOdrzucony);
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.StatusWniosek_Stracony);
            this.AkceptacjaWniosku_Odrzucenie.Activities.Add(this.setStateActivity16);
            codecondition12.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_Odrzucenie);
            this.AkceptacjaWniosku_Odrzucenie.Condition = codecondition12;
            this.AkceptacjaWniosku_Odrzucenie.Name = "AkceptacjaWniosku_Odrzucenie";
            // 
            // AkceptacjaWniosku_KorektaWniosku
            // 
            this.AkceptacjaWniosku_KorektaWniosku.Activities.Add(this.setStateActivity15);
            codecondition13.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_KorektaWniosku);
            this.AkceptacjaWniosku_KorektaWniosku.Condition = codecondition13;
            this.AkceptacjaWniosku_KorektaWniosku.Name = "AkceptacjaWniosku_KorektaWniosku";
            // 
            // AkceptacjaWniosku_Umowa
            // 
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.Komunikat_AkceptacjaWniosku);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.ifElseActivity3);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.StatusWniosek_Umowa);
            this.AkceptacjaWniosku_Umowa.Activities.Add(this.setStateActivity14);
            codecondition14.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaWniosku_Umowa);
            this.AkceptacjaWniosku_Umowa.Condition = codecondition14;
            this.AkceptacjaWniosku_Umowa.Name = "AkceptacjaWniosku_Umowa";
            // 
            // Wniosek_AkceptacjaWniosku
            // 
            this.Wniosek_AkceptacjaWniosku.Activities.Add(this.setStateActivity13);
            codecondition15.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWniosek_AkceptacjaWniosku);
            this.Wniosek_AkceptacjaWniosku.Condition = codecondition15;
            this.Wniosek_AkceptacjaWniosku.Name = "Wniosek_AkceptacjaWniosku";
            // 
            // KorektaOferty_AkceptacjaOferty
            // 
            this.KorektaOferty_AkceptacjaOferty.Activities.Add(this.setStateActivity8);
            codecondition16.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.KorektaOferty_AkceptacjaOferty.Condition = codecondition16;
            this.KorektaOferty_AkceptacjaOferty.Name = "KorektaOferty_AkceptacjaOferty";
            // 
            // AkceptacjaOferty_Telemarketing1
            // 
            this.AkceptacjaOferty_Telemarketing1.Activities.Add(this.StatusOferta_Telefon);
            this.AkceptacjaOferty_Telemarketing1.Activities.Add(this.setStateActivity7);
            codecondition17.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_Telemarketing);
            this.AkceptacjaOferty_Telemarketing1.Condition = codecondition17;
            this.AkceptacjaOferty_Telemarketing1.Name = "AkceptacjaOferty_Telemarketing1";
            // 
            // AkceptacjaOferty_KorektaOferty
            // 
            this.AkceptacjaOferty_KorektaOferty.Activities.Add(this.setStateActivity6);
            codecondition18.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_KorektaOferty);
            this.AkceptacjaOferty_KorektaOferty.Condition = codecondition18;
            this.AkceptacjaOferty_KorektaOferty.Name = "AkceptacjaOferty_KorektaOferty";
            // 
            // AkceptacjaOferty_Odrzucenie
            // 
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.Komunikat_OfertaNiezaakceptowana);
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.StatusOferta_Stracony);
            this.AkceptacjaOferty_Odrzucenie.Activities.Add(this.setStateActivity12);
            codecondition19.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_Odrzucenie);
            this.AkceptacjaOferty_Odrzucenie.Condition = codecondition19;
            this.AkceptacjaOferty_Odrzucenie.Name = "AkceptacjaOferty_Odrzucenie";
            // 
            // AkceptacjaOferty_Wniosek
            // 
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.Komunikat_AkceptacjaOferty);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.ifElseActivity2);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.StatusOferta_Wniosek);
            this.AkceptacjaOferty_Wniosek.Activities.Add(this.setStateActivity11);
            codecondition20.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAkceptacjaOferty_Wniosek);
            this.AkceptacjaOferty_Wniosek.Condition = codecondition20;
            this.AkceptacjaOferty_Wniosek.Name = "AkceptacjaOferty_Wniosek";
            // 
            // Odrzucenie_MailSendAllowed
            // 
            this.Odrzucenie_MailSendAllowed.Activities.Add(this.sendEmail_Stracony);
            this.Odrzucenie_MailSendAllowed.Activities.Add(this.logToHistoryListActivity17);
            codecondition21.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOdrzucenie_MailSendAllowed);
            this.Odrzucenie_MailSendAllowed.Condition = codecondition21;
            this.Odrzucenie_MailSendAllowed.Name = "Odrzucenie_MailSendAllowed";
            // 
            // Oferta_AkceptacjaOferty
            // 
            this.Oferta_AkceptacjaOferty.Activities.Add(this.setStateActivity5);
            codecondition22.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOferta_AkceptacjaOferty);
            this.Oferta_AkceptacjaOferty.Condition = codecondition22;
            this.Oferta_AkceptacjaOferty.Name = "Oferta_AkceptacjaOferty";
            // 
            // Telemarketing_Odrzucenie
            // 
            this.Telemarketing_Odrzucenie.Activities.Add(this.StatusTelefon_Stracony);
            this.Telemarketing_Odrzucenie.Activities.Add(this.setStateActivity10);
            codecondition23.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Odrzucenie);
            this.Telemarketing_Odrzucenie.Condition = codecondition23;
            this.Telemarketing_Odrzucenie.Name = "Telemarketing_Odrzucenie";
            // 
            // Telemarketing_Oferta
            // 
            this.Telemarketing_Oferta.Activities.Add(this.StatusTelefon_Oferta);
            this.Telemarketing_Oferta.Activities.Add(this.setStateActivity9);
            codecondition24.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Oferta);
            this.Telemarketing_Oferta.Condition = codecondition24;
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
            this.faultHandlerActivity5.Activities.Add(this.logERROR_WefyfikacjaEvent);
            this.faultHandlerActivity5.Enabled = false;
            this.faultHandlerActivity5.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity5.Name = "faultHandlerActivity5";
            // 
            // faultHandlersActivity6
            // 
            this.faultHandlersActivity6.Name = "faultHandlersActivity6";
            // 
            // Weryfikacja_Odrzucenie
            // 
            this.Weryfikacja_Odrzucenie.Activities.Add(this.StatusRozmowa_Stracony);
            this.Weryfikacja_Odrzucenie.Activities.Add(this.setStateActivity2);
            codecondition25.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Odrzucenie);
            this.Weryfikacja_Odrzucenie.Condition = codecondition25;
            this.Weryfikacja_Odrzucenie.Name = "Weryfikacja_Odrzucenie";
            // 
            // Weryfikacja_Telemarketing
            // 
            this.Weryfikacja_Telemarketing.Activities.Add(this.StatusRozmowa_Telefon);
            this.Weryfikacja_Telemarketing.Activities.Add(this.setStateActivity4);
            codecondition26.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Telemarketing);
            this.Weryfikacja_Telemarketing.Condition = codecondition26;
            this.Weryfikacja_Telemarketing.Name = "Weryfikacja_Telemarketing";
            // 
            // Weryfikacja_Oferta
            // 
            this.Weryfikacja_Oferta.Activities.Add(this.StatusRozmowa_Oferta);
            this.Weryfikacja_Oferta.Activities.Add(this.setStateActivity3);
            codecondition27.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Oferta);
            this.Weryfikacja_Oferta.Condition = codecondition27;
            this.Weryfikacja_Oferta.Name = "Weryfikacja_Oferta";
            // 
            // faultHandlerActivity3
            // 
            this.faultHandlerActivity3.Activities.Add(this.logERROR_NavigatorInit);
            this.faultHandlerActivity3.Enabled = false;
            this.faultHandlerActivity3.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity3.Name = "faultHandlerActivity3";
            // 
            // Status_Lead_Else
            // 
            this.Status_Lead_Else.Activities.Add(this.setStateActivity27);
            codecondition28.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_ElseIf);
            this.Status_Lead_Else.Condition = codecondition28;
            this.Status_Lead_Else.Name = "Status_Lead_Else";
            // 
            // StatusLeadu_Rozliczenie
            // 
            this.StatusLeadu_Rozliczenie.Activities.Add(this.setStateActivity23);
            codecondition29.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Rozliczenie);
            this.StatusLeadu_Rozliczenie.Condition = codecondition29;
            this.StatusLeadu_Rozliczenie.Name = "StatusLeadu_Rozliczenie";
            // 
            // faultHandlersActivity7
            // 
            this.faultHandlersActivity7.Name = "faultHandlersActivity7";
            // 
            // StatusLeadu_Stracony
            // 
            this.StatusLeadu_Stracony.Activities.Add(this.Navigator_Stracony);
            codecondition30.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Stracony);
            this.StatusLeadu_Stracony.Condition = codecondition30;
            this.StatusLeadu_Stracony.Name = "StatusLeadu_Stracony";
            // 
            // StatusLeadu_Uruchomiony
            // 
            this.StatusLeadu_Uruchomiony.Activities.Add(this.Navigator_Uruchomienie);
            codecondition31.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Uruchomiony);
            this.StatusLeadu_Uruchomiony.Condition = codecondition31;
            this.StatusLeadu_Uruchomiony.Name = "StatusLeadu_Uruchomiony";
            // 
            // StatusLeadu_Umowa
            // 
            this.StatusLeadu_Umowa.Activities.Add(this.Navigator_Umowa);
            codecondition32.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Umowa);
            this.StatusLeadu_Umowa.Condition = codecondition32;
            this.StatusLeadu_Umowa.Name = "StatusLeadu_Umowa";
            // 
            // StatusLeadu_Wniosek
            // 
            this.StatusLeadu_Wniosek.Activities.Add(this.Navigator_Wniosek);
            codecondition33.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Wniosek);
            this.StatusLeadu_Wniosek.Condition = codecondition33;
            this.StatusLeadu_Wniosek.Name = "StatusLeadu_Wniosek";
            // 
            // StatusLeadu_Oferta
            // 
            this.StatusLeadu_Oferta.Activities.Add(this.Navigator_Oferta);
            codecondition34.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Oferta);
            this.StatusLeadu_Oferta.Condition = codecondition34;
            this.StatusLeadu_Oferta.Name = "StatusLeadu_Oferta";
            // 
            // StatusLeadu_Telefon
            // 
            this.StatusLeadu_Telefon.Activities.Add(this.Navigator_Telemarketing);
            codecondition35.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsStatusLeadu_Telefon);
            this.StatusLeadu_Telefon.Condition = codecondition35;
            this.StatusLeadu_Telefon.Name = "StatusLeadu_Telefon";
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
            activitybind31.Name = "Workflow1";
            activitybind31.Path = "logRozliczenie_DodajDoRozliczen";
            this.logToHistoryListActivity3.HistoryOutcome = "";
            this.logToHistoryListActivity3.Name = "logToHistoryListActivity3";
            this.logToHistoryListActivity3.OtherData = "";
            this.logToHistoryListActivity3.UserId = -1;
            this.logToHistoryListActivity3.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind31)));
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
            // ifElseActivity11
            // 
            this.ifElseActivity11.Activities.Add(this.Dokumentacja_Rozliczenie);
            this.ifElseActivity11.Name = "ifElseActivity11";
            // 
            // onWorkflowItemChanged11
            // 
            this.onWorkflowItemChanged11.AfterProperties = null;
            this.onWorkflowItemChanged11.BeforeProperties = null;
            correlationtoken7.Name = "myWorkflowToken";
            correlationtoken7.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged11.CorrelationToken = correlationtoken7;
            this.onWorkflowItemChanged11.Name = "onWorkflowItemChanged11";
            // 
            // SetCT_Dokumentacja
            // 
            this.SetCT_Dokumentacja.Name = "SetCT_Dokumentacja";
            this.SetCT_Dokumentacja.ExecuteCode += new System.EventHandler(this.SetCT_Dokumentacja_ExecuteCode);
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
            // ifElseActivity123
            // 
            this.ifElseActivity123.Activities.Add(this.Uruchomienie_Dokumentacja);
            this.ifElseActivity123.Name = "ifElseActivity123";
            // 
            // onWorkflowItemChanged12
            // 
            this.onWorkflowItemChanged12.AfterProperties = null;
            this.onWorkflowItemChanged12.BeforeProperties = null;
            this.onWorkflowItemChanged12.CorrelationToken = correlationtoken1;
            this.onWorkflowItemChanged12.Name = "onWorkflowItemChanged12";
            // 
            // SetCT_Uruchomienie
            // 
            this.SetCT_Uruchomienie.Name = "SetCT_Uruchomienie";
            this.SetCT_Uruchomienie.ExecuteCode += new System.EventHandler(this.SetCT_Uruchomienie_ExecuteCode);
            // 
            // setState_Uruchomienie
            // 
            correlationtoken9.Name = "myWorkflowToken";
            correlationtoken9.OwnerActivityName = "Workflow1";
            this.setState_Uruchomienie.CorrelationToken = correlationtoken9;
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
            // TestAkceptacjaUmowy
            // 
            this.TestAkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_Uruchomienie);
            this.TestAkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_Odrzucenie);
            this.TestAkceptacjaUmowy.Activities.Add(this.AkceptacjaUmowy_Telemarketing);
            this.TestAkceptacjaUmowy.Name = "TestAkceptacjaUmowy";
            // 
            // onWorkflowItemChanged10
            // 
            this.onWorkflowItemChanged10.AfterProperties = null;
            this.onWorkflowItemChanged10.BeforeProperties = null;
            this.onWorkflowItemChanged10.CorrelationToken = correlationtoken2;
            this.onWorkflowItemChanged10.Name = "onWorkflowItemChanged10";
            // 
            // SetCT_AkceptacjaUmowy
            // 
            this.SetCT_AkceptacjaUmowy.Name = "SetCT_AkceptacjaUmowy";
            this.SetCT_AkceptacjaUmowy.ExecuteCode += new System.EventHandler(this.SetCT_AkceptacjaUmowy_ExecuteCode);
            // 
            // setState_AkceptacjaUmowy
            // 
            correlationtoken10.Name = "myWorkflowToken";
            correlationtoken10.OwnerActivityName = "Workflow1";
            this.setState_AkceptacjaUmowy.CorrelationToken = correlationtoken10;
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
            // ifElseActivity9
            // 
            this.ifElseActivity9.Activities.Add(this.Umowa_AkceptacjaUmowy);
            this.ifElseActivity9.Name = "ifElseActivity9";
            // 
            // onWorkflowItemChanged9
            // 
            this.onWorkflowItemChanged9.AfterProperties = null;
            this.onWorkflowItemChanged9.BeforeProperties = null;
            correlationtoken11.Name = "myWorkflowToken";
            correlationtoken11.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged9.CorrelationToken = correlationtoken11;
            this.onWorkflowItemChanged9.Name = "onWorkflowItemChanged9";
            // 
            // SetCT_Umowa
            // 
            this.SetCT_Umowa.Name = "SetCT_Umowa";
            this.SetCT_Umowa.ExecuteCode += new System.EventHandler(this.SetCT_Umowa_ExecuteCode);
            // 
            // setState_Umowa
            // 
            correlationtoken12.Name = "myWorkflowToken";
            correlationtoken12.OwnerActivityName = "Workflow1";
            this.setState_Umowa.CorrelationToken = correlationtoken12;
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
            // ifElseActivity8
            // 
            this.ifElseActivity8.Activities.Add(this.KorektaWniosku_AkceptacjaWniosku);
            this.ifElseActivity8.Name = "ifElseActivity8";
            // 
            // onWorkflowItemChanged8
            // 
            this.onWorkflowItemChanged8.AfterProperties = null;
            this.onWorkflowItemChanged8.BeforeProperties = null;
            correlationtoken13.Name = "myWorkflowToken";
            correlationtoken13.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged8.CorrelationToken = correlationtoken13;
            this.onWorkflowItemChanged8.Name = "onWorkflowItemChanged8";
            // 
            // SetCT_Wniosek1
            // 
            this.SetCT_Wniosek1.Name = "SetCT_Wniosek1";
            this.SetCT_Wniosek1.ExecuteCode += new System.EventHandler(this.SetCT_Wniosek_ExecuteCode);
            // 
            // setState_KorektaWniosku
            // 
            correlationtoken14.Name = "myWorkflowToken";
            correlationtoken14.OwnerActivityName = "Workflow1";
            this.setState_KorektaWniosku.CorrelationToken = correlationtoken14;
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
            // ifElseActivity7
            // 
            this.ifElseActivity7.Activities.Add(this.AkceptacjaWniosku_Umowa);
            this.ifElseActivity7.Activities.Add(this.AkceptacjaWniosku_KorektaWniosku);
            this.ifElseActivity7.Activities.Add(this.AkceptacjaWniosku_Odrzucenie);
            this.ifElseActivity7.Name = "ifElseActivity7";
            // 
            // onWorkflowItemChanged7
            // 
            this.onWorkflowItemChanged7.AfterProperties = null;
            this.onWorkflowItemChanged7.BeforeProperties = null;
            this.onWorkflowItemChanged7.CorrelationToken = correlationtoken3;
            this.onWorkflowItemChanged7.Name = "onWorkflowItemChanged7";
            // 
            // SetCT_AkceptacjaWniosku
            // 
            this.SetCT_AkceptacjaWniosku.Name = "SetCT_AkceptacjaWniosku";
            this.SetCT_AkceptacjaWniosku.ExecuteCode += new System.EventHandler(this.SetCT_AkceptacjaWniosku_ExecuteCode);
            // 
            // setState_AkceptacjaWniosku
            // 
            correlationtoken15.Name = "myWorkflowToken";
            correlationtoken15.OwnerActivityName = "Workflow1";
            this.setState_AkceptacjaWniosku.CorrelationToken = correlationtoken15;
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
            // ifElseActivity6
            // 
            this.ifElseActivity6.Activities.Add(this.Wniosek_AkceptacjaWniosku);
            this.ifElseActivity6.Name = "ifElseActivity6";
            // 
            // onWorkflowItemChanged6
            // 
            this.onWorkflowItemChanged6.AfterProperties = null;
            this.onWorkflowItemChanged6.BeforeProperties = null;
            correlationtoken16.Name = "myWorkflowToken";
            correlationtoken16.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged6.CorrelationToken = correlationtoken16;
            this.onWorkflowItemChanged6.Name = "onWorkflowItemChanged6";
            // 
            // codeDodajDoRozliczen
            // 
            this.codeDodajDoRozliczen.Name = "codeDodajDoRozliczen";
            this.codeDodajDoRozliczen.ExecuteCode += new System.EventHandler(this.codeDodajDoRozliczen_ExecuteCode);
            // 
            // SetCT_Wniosek
            // 
            this.SetCT_Wniosek.Name = "SetCT_Wniosek";
            this.SetCT_Wniosek.ExecuteCode += new System.EventHandler(this.SetCT_Wniosek_ExecuteCode);
            // 
            // setState_Wniosek
            // 
            correlationtoken17.Name = "myWorkflowToken";
            correlationtoken17.OwnerActivityName = "Workflow1";
            this.setState_Wniosek.CorrelationToken = correlationtoken17;
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
            // ifElseActivity5
            // 
            this.ifElseActivity5.Activities.Add(this.KorektaOferty_AkceptacjaOferty);
            this.ifElseActivity5.Name = "ifElseActivity5";
            // 
            // onWorkflowItemChanged5
            // 
            this.onWorkflowItemChanged5.AfterProperties = null;
            this.onWorkflowItemChanged5.BeforeProperties = null;
            correlationtoken18.Name = "myWorkflowToken";
            correlationtoken18.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged5.CorrelationToken = correlationtoken18;
            this.onWorkflowItemChanged5.Name = "onWorkflowItemChanged5";
            // 
            // SetCT_Oferta1
            // 
            this.SetCT_Oferta1.Name = "SetCT_Oferta1";
            this.SetCT_Oferta1.ExecuteCode += new System.EventHandler(this.SetCT_Oferta_ExecuteCode);
            // 
            // setState_KorektaOferty
            // 
            correlationtoken19.Name = "myWorkflowToken";
            correlationtoken19.OwnerActivityName = "Workflow1";
            this.setState_KorektaOferty.CorrelationToken = correlationtoken19;
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
            // AkceptacjaOferty_Telemarketing
            // 
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_Wniosek);
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_Odrzucenie);
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_KorektaOferty);
            this.AkceptacjaOferty_Telemarketing.Activities.Add(this.AkceptacjaOferty_Telemarketing1);
            this.AkceptacjaOferty_Telemarketing.Name = "AkceptacjaOferty_Telemarketing";
            // 
            // onWorkflowItemChanged4
            // 
            this.onWorkflowItemChanged4.AfterProperties = null;
            this.onWorkflowItemChanged4.BeforeProperties = null;
            this.onWorkflowItemChanged4.CorrelationToken = correlationtoken4;
            this.onWorkflowItemChanged4.Name = "onWorkflowItemChanged4";
            // 
            // SetCT_AkceptacjaOferty
            // 
            this.SetCT_AkceptacjaOferty.Name = "SetCT_AkceptacjaOferty";
            this.SetCT_AkceptacjaOferty.ExecuteCode += new System.EventHandler(this.SetCT_AkceptacjaOferty_ExecuteCode);
            // 
            // setState_AkceptacjaOferty
            // 
            correlationtoken20.Name = "myWorkflowToken";
            correlationtoken20.OwnerActivityName = "Workflow1";
            this.setState_AkceptacjaOferty.CorrelationToken = correlationtoken20;
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
            // Oferta_Routing
            // 
            this.Oferta_Routing.Activities.Add(this.Oferta_AkceptacjaOferty);
            this.Oferta_Routing.Name = "Oferta_Routing";
            // 
            // onWorkflowItemChanged2
            // 
            this.onWorkflowItemChanged2.AfterProperties = null;
            this.onWorkflowItemChanged2.BeforeProperties = null;
            correlationtoken21.Name = "myWorkflowToken";
            correlationtoken21.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged2.CorrelationToken = correlationtoken21;
            this.onWorkflowItemChanged2.Name = "onWorkflowItemChanged2";
            // 
            // SetCT_Oferta
            // 
            this.SetCT_Oferta.Name = "SetCT_Oferta";
            this.SetCT_Oferta.ExecuteCode += new System.EventHandler(this.SetCT_Oferta_ExecuteCode);
            // 
            // setState_Oferta
            // 
            correlationtoken22.Name = "myWorkflowToken";
            correlationtoken22.OwnerActivityName = "Workflow1";
            this.setState_Oferta.CorrelationToken = correlationtoken22;
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
            // Telemarketing_Routing
            // 
            this.Telemarketing_Routing.Activities.Add(this.Telemarketing_Oferta);
            this.Telemarketing_Routing.Activities.Add(this.Telemarketing_Odrzucenie);
            this.Telemarketing_Routing.Name = "Telemarketing_Routing";
            // 
            // onWorkflowItemChanged3
            // 
            this.onWorkflowItemChanged3.AfterProperties = null;
            this.onWorkflowItemChanged3.BeforeProperties = null;
            correlationtoken23.Name = "myWorkflowToken";
            correlationtoken23.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged3.CorrelationToken = correlationtoken23;
            this.onWorkflowItemChanged3.Name = "onWorkflowItemChanged3";
            // 
            // SetCT_Telemarketing
            // 
            this.SetCT_Telemarketing.Name = "SetCT_Telemarketing";
            this.SetCT_Telemarketing.ExecuteCode += new System.EventHandler(this.SetCT_Telemarketing_ExecuteCode);
            // 
            // setState_Telemarketing
            // 
            correlationtoken24.Name = "myWorkflowToken";
            correlationtoken24.OwnerActivityName = "Workflow1";
            this.setState_Telemarketing.CorrelationToken = correlationtoken24;
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
            // faultHandlersActivity4
            // 
            this.faultHandlersActivity4.Activities.Add(this.faultHandlerActivity4);
            this.faultHandlersActivity4.Name = "faultHandlersActivity4";
            // 
            // SetCT_Weryfikacja
            // 
            this.SetCT_Weryfikacja.Name = "SetCT_Weryfikacja";
            this.SetCT_Weryfikacja.ExecuteCode += new System.EventHandler(this.SetCT_Weryfikacja_ExecuteCode);
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
            correlationtoken25.Name = "myWorkflowToken";
            correlationtoken25.OwnerActivityName = "Workflow1";
            this.setState_Weryfikacja.CorrelationToken = correlationtoken25;
            this.setState_Weryfikacja.Name = "setState_Weryfikacja";
            this.setState_Weryfikacja.State = 15;
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
            // onWorkflowItemChanged13
            // 
            this.onWorkflowItemChanged13.AfterProperties = null;
            this.onWorkflowItemChanged13.BeforeProperties = null;
            correlationtoken26.Name = "myWorkflowToken";
            correlationtoken26.OwnerActivityName = "Workflow1";
            this.onWorkflowItemChanged13.CorrelationToken = correlationtoken26;
            this.onWorkflowItemChanged13.Name = "onWorkflowItemChanged13";
            // 
            // faultHandlersActivity3
            // 
            this.faultHandlersActivity3.Activities.Add(this.faultHandlerActivity3);
            this.faultHandlersActivity3.Name = "faultHandlersActivity3";
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
            correlationtoken27.Name = "myWorkflowToken";
            correlationtoken27.OwnerActivityName = "Workflow1";
            this.onWorkflowActivated1.CorrelationToken = correlationtoken27;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind32.Name = "Workflow1";
            activitybind32.Path = "workflowProperties";
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind32)));
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
            this.Dokumentacja_OnChange.Activities.Add(this.ifElseActivity11);
            this.Dokumentacja_OnChange.Name = "Dokumentacja_OnChange";
            // 
            // stateInitializationActivity10
            // 
            this.stateInitializationActivity10.Activities.Add(this.logToHistoryListActivity9);
            this.stateInitializationActivity10.Activities.Add(this.setState_Dokumentacja);
            this.stateInitializationActivity10.Activities.Add(this.SetCT_Dokumentacja);
            this.stateInitializationActivity10.Name = "stateInitializationActivity10";
            // 
            // Uruchomienie_OnChange
            // 
            this.Uruchomienie_OnChange.Activities.Add(this.onWorkflowItemChanged12);
            this.Uruchomienie_OnChange.Activities.Add(this.ifElseActivity123);
            this.Uruchomienie_OnChange.Name = "Uruchomienie_OnChange";
            // 
            // stateInitializationActivity11
            // 
            this.stateInitializationActivity11.Activities.Add(this.logToHistoryListActivity10);
            this.stateInitializationActivity11.Activities.Add(this.setState_Uruchomienie);
            this.stateInitializationActivity11.Activities.Add(this.SetCT_Uruchomienie);
            this.stateInitializationActivity11.Name = "stateInitializationActivity11";
            // 
            // AkceptacjaUmowy_OnChange
            // 
            this.AkceptacjaUmowy_OnChange.Activities.Add(this.onWorkflowItemChanged10);
            this.AkceptacjaUmowy_OnChange.Activities.Add(this.TestAkceptacjaUmowy);
            this.AkceptacjaUmowy_OnChange.Name = "AkceptacjaUmowy_OnChange";
            // 
            // stateInitializationActivity14
            // 
            this.stateInitializationActivity14.Activities.Add(this.logToHistoryListActivity13);
            this.stateInitializationActivity14.Activities.Add(this.setState_AkceptacjaUmowy);
            this.stateInitializationActivity14.Activities.Add(this.SetCT_AkceptacjaUmowy);
            this.stateInitializationActivity14.Name = "stateInitializationActivity14";
            // 
            // Umowa_OnChange
            // 
            this.Umowa_OnChange.Activities.Add(this.onWorkflowItemChanged9);
            this.Umowa_OnChange.Activities.Add(this.ifElseActivity9);
            this.Umowa_OnChange.Name = "Umowa_OnChange";
            // 
            // stateInitializationActivity9
            // 
            this.stateInitializationActivity9.Activities.Add(this.logToHistoryListActivity8);
            this.stateInitializationActivity9.Activities.Add(this.setState_Umowa);
            this.stateInitializationActivity9.Activities.Add(this.SetCT_Umowa);
            this.stateInitializationActivity9.Name = "stateInitializationActivity9";
            // 
            // KorektaWniosku_OnChange
            // 
            this.KorektaWniosku_OnChange.Activities.Add(this.onWorkflowItemChanged8);
            this.KorektaWniosku_OnChange.Activities.Add(this.ifElseActivity8);
            this.KorektaWniosku_OnChange.Name = "KorektaWniosku_OnChange";
            // 
            // stateInitializationActivity13
            // 
            this.stateInitializationActivity13.Activities.Add(this.logToHistoryListActivity12);
            this.stateInitializationActivity13.Activities.Add(this.setState_KorektaWniosku);
            this.stateInitializationActivity13.Activities.Add(this.SetCT_Wniosek1);
            this.stateInitializationActivity13.Name = "stateInitializationActivity13";
            // 
            // AkceptacjaWniosku_OnChange
            // 
            this.AkceptacjaWniosku_OnChange.Activities.Add(this.onWorkflowItemChanged7);
            this.AkceptacjaWniosku_OnChange.Activities.Add(this.ifElseActivity7);
            this.AkceptacjaWniosku_OnChange.Name = "AkceptacjaWniosku_OnChange";
            // 
            // stateInitializationActivity8
            // 
            this.stateInitializationActivity8.Activities.Add(this.logToHistoryListActivity7);
            this.stateInitializationActivity8.Activities.Add(this.setState_AkceptacjaWniosku);
            this.stateInitializationActivity8.Activities.Add(this.SetCT_AkceptacjaWniosku);
            this.stateInitializationActivity8.Name = "stateInitializationActivity8";
            // 
            // Wniosek_OnChange
            // 
            this.Wniosek_OnChange.Activities.Add(this.onWorkflowItemChanged6);
            this.Wniosek_OnChange.Activities.Add(this.ifElseActivity6);
            this.Wniosek_OnChange.Name = "Wniosek_OnChange";
            // 
            // stateInitializationActivity7
            // 
            this.stateInitializationActivity7.Activities.Add(this.logToHistoryListActivity6);
            this.stateInitializationActivity7.Activities.Add(this.setState_Wniosek);
            this.stateInitializationActivity7.Activities.Add(this.SetCT_Wniosek);
            this.stateInitializationActivity7.Activities.Add(this.codeDodajDoRozliczen);
            this.stateInitializationActivity7.Name = "stateInitializationActivity7";
            // 
            // KorektaOferty_OnChange
            // 
            this.KorektaOferty_OnChange.Activities.Add(this.onWorkflowItemChanged5);
            this.KorektaOferty_OnChange.Activities.Add(this.ifElseActivity5);
            this.KorektaOferty_OnChange.Name = "KorektaOferty_OnChange";
            // 
            // stateInitializationActivity6
            // 
            this.stateInitializationActivity6.Activities.Add(this.logKorektaOferty);
            this.stateInitializationActivity6.Activities.Add(this.setState_KorektaOferty);
            this.stateInitializationActivity6.Activities.Add(this.SetCT_Oferta1);
            this.stateInitializationActivity6.Name = "stateInitializationActivity6";
            // 
            // AkceptacjaOferty_OnChange
            // 
            this.AkceptacjaOferty_OnChange.Activities.Add(this.onWorkflowItemChanged4);
            this.AkceptacjaOferty_OnChange.Activities.Add(this.AkceptacjaOferty_Telemarketing);
            this.AkceptacjaOferty_OnChange.Name = "AkceptacjaOferty_OnChange";
            // 
            // stateInitializationActivity5
            // 
            this.stateInitializationActivity5.Activities.Add(this.logToHistoryListActivity5);
            this.stateInitializationActivity5.Activities.Add(this.setState_AkceptacjaOferty);
            this.stateInitializationActivity5.Activities.Add(this.SetCT_AkceptacjaOferty);
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
            this.Oferta_OnChange.Activities.Add(this.Oferta_Routing);
            this.Oferta_OnChange.Name = "Oferta_OnChange";
            // 
            // stateInitializationActivity4
            // 
            this.stateInitializationActivity4.Activities.Add(this.logToHistoryListActivity15);
            this.stateInitializationActivity4.Activities.Add(this.setState_Oferta);
            this.stateInitializationActivity4.Activities.Add(this.SetCT_Oferta);
            this.stateInitializationActivity4.Name = "stateInitializationActivity4";
            // 
            // Telemarketing_OnChange
            // 
            this.Telemarketing_OnChange.Activities.Add(this.onWorkflowItemChanged3);
            this.Telemarketing_OnChange.Activities.Add(this.Telemarketing_Routing);
            this.Telemarketing_OnChange.Name = "Telemarketing_OnChange";
            // 
            // stateInitializationActivity3
            // 
            this.stateInitializationActivity3.Activities.Add(this.logToHistoryListActivity16);
            this.stateInitializationActivity3.Activities.Add(this.setState_Telemarketing);
            this.stateInitializationActivity3.Activities.Add(this.SetCT_Telemarketing);
            this.stateInitializationActivity3.Name = "stateInitializationActivity3";
            // 
            // stateInitializationActivity1
            // 
            this.stateInitializationActivity1.Activities.Add(this.setState_Weryfikacja);
            this.stateInitializationActivity1.Activities.Add(this.logToHistoryListActivity14);
            this.stateInitializationActivity1.Activities.Add(this.SetCT_Weryfikacja);
            this.stateInitializationActivity1.Activities.Add(this.faultHandlersActivity4);
            this.stateInitializationActivity1.Name = "stateInitializationActivity1";
            // 
            // Weryfikacja_OnChange
            // 
            this.Weryfikacja_OnChange.Activities.Add(this.onWorkflowItemChanged13);
            this.Weryfikacja_OnChange.Activities.Add(this.Weryfikacja_Routing);
            this.Weryfikacja_OnChange.Activities.Add(this.faultHandlersActivity5);
            this.Weryfikacja_OnChange.Name = "Weryfikacja_OnChange";
            // 
            // stateInitializationActivity15
            // 
            this.stateInitializationActivity15.Activities.Add(this.logRouter);
            this.stateInitializationActivity15.Activities.Add(this.Navigator_Routing);
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

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_WefyfikacjaEvent;

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
