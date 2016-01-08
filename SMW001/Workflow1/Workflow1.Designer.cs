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

namespace SMW001.Workflow1
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
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind9 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind10 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind11 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind12 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind13 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind14 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind15 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind16 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind17 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition5 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition6 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition7 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition8 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Runtime.CorrelationToken correlationtoken2 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind18 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken3 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken4 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken5 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.Runtime.CorrelationToken correlationtoken6 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind19 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind20 = new System.Workflow.ComponentModel.ActivityBind();
            this.logToHistoryListActivity83 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity32 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity30 = new System.Workflow.Activities.SetStateActivity();
            this.setStateActivity28 = new System.Workflow.Activities.SetStateActivity();
            this.Else2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifOdrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifTelemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifWeryfikacja = new System.Workflow.Activities.IfElseBranchActivity();
            this.logToHistoryListActivity1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity17 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendEmail_Stracony = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.logToHistoryListActivity58 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity71 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity10 = new System.Workflow.Activities.SetStateActivity();
            this.StatusTelefon_Stracony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity34 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity4 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity4 = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity57 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.ErrorHandler_Weryfikacja = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity70 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Stracony = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity31 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.setStateActivity4 = new System.Workflow.Activities.SetStateActivity();
            this.StatusRozmowa_Telefon = new System.Workflow.Activities.CodeActivity();
            this.logToHistoryListActivity30 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logERROR_NavigatorInit = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.Navigator_Routing_ver2 = new System.Workflow.Activities.IfElseActivity();
            this.logNavigator = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity68 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logToHistoryListActivity3 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.faultHandlerActivity1 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.Odrzucenie_MailSendAllowed = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity6 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity2 = new System.Workflow.Activities.IfElseBranchActivity();
            this.Telemarketing_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity4 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlerActivity5 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifElseBranchActivity1 = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlersActivity6 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Weryfikacja_Odrzucenie = new System.Workflow.Activities.IfElseBranchActivity();
            this.Weryfikacja_Telemarketing = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity3 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.ifEtapNotNull = new System.Workflow.Activities.IfElseBranchActivity();
            this.faultHandlerActivity2 = new System.Workflow.ComponentModel.FaultHandlerActivity();
            this.faultHandlersActivity2 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity26 = new System.Workflow.Activities.SetStateActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity2 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.SetCT_Odrzucony = new System.Workflow.Activities.CodeActivity();
            this.setState_Odrzucony = new Microsoft.SharePoint.WorkflowActions.SetState();
            this.faultHandlersActivity9 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.Telemarketing_Routing = new System.Workflow.Activities.IfElseActivity();
            this.logToHistoryListActivity32 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.logTEST1 = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
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
            this.logTEST = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowItemChanged13 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged();
            this.faultHandlersActivity3 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.TestEtap = new System.Workflow.Activities.IfElseActivity();
            this.logRouter = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.faultHandlersActivity1 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.codeSetup = new System.Workflow.Activities.CodeActivity();
            this.logZainicjowany = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.onWorkflowActivated2 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            this.stateInitializationActivity2 = new System.Workflow.Activities.StateInitializationActivity();
            this.Telemarketing_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity3 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity1 = new System.Workflow.Activities.StateInitializationActivity();
            this.Weryfikacja_OnChange = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity15 = new System.Workflow.Activities.StateInitializationActivity();
            this.eventDrivenActivity1 = new System.Workflow.Activities.EventDrivenActivity();
            this.End = new System.Workflow.Activities.StateActivity();
            this.Odrzucenie = new System.Workflow.Activities.StateActivity();
            this.Telemarketing = new System.Workflow.Activities.StateActivity();
            this.Weryfikacja = new System.Workflow.Activities.StateActivity();
            this.Navigator = new System.Workflow.Activities.StateActivity();
            this.Start = new System.Workflow.Activities.StateActivity();
            // 
            // logToHistoryListActivity83
            // 
            this.logToHistoryListActivity83.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity83.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logToHistoryListActivity83.HistoryDescription = "Etap nieobsługiwany";
            this.logToHistoryListActivity83.HistoryOutcome = "";
            this.logToHistoryListActivity83.Name = "logToHistoryListActivity83";
            this.logToHistoryListActivity83.OtherData = "";
            this.logToHistoryListActivity83.UserId = -1;
            // 
            // setStateActivity32
            // 
            this.setStateActivity32.Name = "setStateActivity32";
            this.setStateActivity32.TargetStateName = "Odrzucenie";
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
            // Else2
            // 
            this.Else2.Activities.Add(this.logToHistoryListActivity83);
            this.Else2.Name = "Else2";
            // 
            // ifOdrzucenie
            // 
            this.ifOdrzucenie.Activities.Add(this.setStateActivity32);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isOdrzucenie);
            this.ifOdrzucenie.Condition = codecondition1;
            this.ifOdrzucenie.Name = "ifOdrzucenie";
            // 
            // ifTelemarketing
            // 
            this.ifTelemarketing.Activities.Add(this.setStateActivity30);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isTelemarketing);
            this.ifTelemarketing.Condition = codecondition2;
            this.ifTelemarketing.Name = "ifTelemarketing";
            // 
            // ifWeryfikacja
            // 
            this.ifWeryfikacja.Activities.Add(this.setStateActivity28);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isWeryfikacja);
            this.ifWeryfikacja.Condition = codecondition3;
            this.ifWeryfikacja.Name = "ifWeryfikacja";
            // 
            // logToHistoryListActivity1
            // 
            this.logToHistoryListActivity1.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity1.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind1.Name = "Workflow1";
            activitybind1.Path = "logErrorMessage_HistoryDescription";
            activitybind2.Name = "Workflow1";
            activitybind2.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity1.Name = "logToHistoryListActivity1";
            this.logToHistoryListActivity1.OtherData = "";
            this.logToHistoryListActivity1.UserId = -1;
            this.logToHistoryListActivity1.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.logToHistoryListActivity1.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
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
            activitybind3.Name = "Workflow1";
            activitybind3.Path = "Mail_BCC";
            activitybind4.Name = "Workflow1";
            activitybind4.Path = "Mail_Body";
            activitybind5.Name = "Workflow1";
            activitybind5.Path = "Mail_CC";
            correlationtoken1.Name = "myToken";
            correlationtoken1.OwnerActivityName = "Workflow1";
            this.sendEmail_Stracony.CorrelationToken = correlationtoken1;
            activitybind6.Name = "Workflow1";
            activitybind6.Path = "Mail_From";
            this.sendEmail_Stracony.Headers = null;
            this.sendEmail_Stracony.IncludeStatus = false;
            this.sendEmail_Stracony.Name = "sendEmail_Stracony";
            activitybind7.Name = "Workflow1";
            activitybind7.Path = "Mail_Subject";
            activitybind8.Name = "Workflow1";
            activitybind8.Path = "Mail_To";
            this.sendEmail_Stracony.MethodInvoking += new System.EventHandler(this.sendEmail_Stracony_MethodInvoking);
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.FromProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.sendEmail_Stracony.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            // 
            // logToHistoryListActivity58
            // 
            this.logToHistoryListActivity58.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity58.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind9.Name = "Workflow1";
            activitybind9.Path = "logErrorMessage_HistoryDescription";
            activitybind10.Name = "Workflow1";
            activitybind10.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity58.Name = "logToHistoryListActivity58";
            this.logToHistoryListActivity58.OtherData = "";
            this.logToHistoryListActivity58.UserId = -1;
            this.logToHistoryListActivity58.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind9)));
            this.logToHistoryListActivity58.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind10)));
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
            // logToHistoryListActivity4
            // 
            this.logToHistoryListActivity4.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity4.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind11.Name = "Workflow1";
            activitybind11.Path = "logErrorMessage_HistoryDescription";
            activitybind12.Name = "Workflow1";
            activitybind12.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity4.Name = "logToHistoryListActivity4";
            this.logToHistoryListActivity4.OtherData = "";
            this.logToHistoryListActivity4.UserId = -1;
            this.logToHistoryListActivity4.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind11)));
            this.logToHistoryListActivity4.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind12)));
            // 
            // codeActivity4
            // 
            this.codeActivity4.Name = "codeActivity4";
            this.codeActivity4.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
            // 
            // logToHistoryListActivity57
            // 
            this.logToHistoryListActivity57.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity57.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind13.Name = "Workflow1";
            activitybind13.Path = "logErrorMessage_HistoryDescription";
            activitybind14.Name = "Workflow1";
            activitybind14.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity57.Name = "logToHistoryListActivity57";
            this.logToHistoryListActivity57.OtherData = "";
            this.logToHistoryListActivity57.UserId = -1;
            this.logToHistoryListActivity57.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind13)));
            this.logToHistoryListActivity57.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind14)));
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
            // Navigator_Routing_ver2
            // 
            this.Navigator_Routing_ver2.Activities.Add(this.ifWeryfikacja);
            this.Navigator_Routing_ver2.Activities.Add(this.ifTelemarketing);
            this.Navigator_Routing_ver2.Activities.Add(this.ifOdrzucenie);
            this.Navigator_Routing_ver2.Activities.Add(this.Else2);
            this.Navigator_Routing_ver2.Name = "Navigator_Routing_ver2";
            // 
            // logNavigator
            // 
            this.logNavigator.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logNavigator.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logNavigator.HistoryDescription = "Navigator";
            activitybind15.Name = "Workflow1";
            activitybind15.Path = "logNavigator_HistoryOutcome";
            this.logNavigator.Name = "logNavigator";
            this.logNavigator.OtherData = "";
            this.logNavigator.UserId = -1;
            this.logNavigator.MethodInvoking += new System.EventHandler(this.SetNavigatorMessage);
            this.logNavigator.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind15)));
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
            // logToHistoryListActivity3
            // 
            this.logToHistoryListActivity3.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logToHistoryListActivity3.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind16.Name = "Workflow1";
            activitybind16.Path = "logErrorMessage_HistoryDescription";
            activitybind17.Name = "Workflow1";
            activitybind17.Path = "logErrorMessage_HistoryOutcome";
            this.logToHistoryListActivity3.Name = "logToHistoryListActivity3";
            this.logToHistoryListActivity3.OtherData = "";
            this.logToHistoryListActivity3.UserId = -1;
            this.logToHistoryListActivity3.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind16)));
            this.logToHistoryListActivity3.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind17)));
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
            // 
            // faultHandlerActivity1
            // 
            this.faultHandlerActivity1.Activities.Add(this.codeActivity2);
            this.faultHandlerActivity1.Activities.Add(this.logToHistoryListActivity1);
            this.faultHandlerActivity1.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity1.Name = "faultHandlerActivity1";
            // 
            // Odrzucenie_MailSendAllowed
            // 
            this.Odrzucenie_MailSendAllowed.Activities.Add(this.sendEmail_Stracony);
            this.Odrzucenie_MailSendAllowed.Activities.Add(this.logToHistoryListActivity17);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsOdrzucenie_MailSendAllowed);
            this.Odrzucenie_MailSendAllowed.Condition = codecondition4;
            this.Odrzucenie_MailSendAllowed.Name = "Odrzucenie_MailSendAllowed";
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
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsTelemarketing_Odrzucenie);
            this.Telemarketing_Odrzucenie.Condition = codecondition5;
            this.Telemarketing_Odrzucenie.Name = "Telemarketing_Odrzucenie";
            // 
            // faultHandlerActivity4
            // 
            this.faultHandlerActivity4.Activities.Add(this.codeActivity4);
            this.faultHandlerActivity4.Activities.Add(this.logToHistoryListActivity4);
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
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Odrzucenie);
            this.Weryfikacja_Odrzucenie.Condition = codecondition6;
            this.Weryfikacja_Odrzucenie.Name = "Weryfikacja_Odrzucenie";
            // 
            // Weryfikacja_Telemarketing
            // 
            this.Weryfikacja_Telemarketing.Activities.Add(this.logToHistoryListActivity30);
            this.Weryfikacja_Telemarketing.Activities.Add(this.StatusRozmowa_Telefon);
            this.Weryfikacja_Telemarketing.Activities.Add(this.setStateActivity4);
            codecondition7.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsWeryfikacja_Telemarketing);
            this.Weryfikacja_Telemarketing.Condition = codecondition7;
            this.Weryfikacja_Telemarketing.Name = "Weryfikacja_Telemarketing";
            // 
            // faultHandlerActivity3
            // 
            this.faultHandlerActivity3.Activities.Add(this.logERROR_NavigatorInit);
            this.faultHandlerActivity3.Enabled = false;
            this.faultHandlerActivity3.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity3.Name = "faultHandlerActivity3";
            // 
            // ifEtapNotNull
            // 
            this.ifEtapNotNull.Activities.Add(this.logToHistoryListActivity68);
            this.ifEtapNotNull.Activities.Add(this.logNavigator);
            this.ifEtapNotNull.Activities.Add(this.Navigator_Routing_ver2);
            codecondition8.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.isEtapNotNull);
            this.ifEtapNotNull.Condition = codecondition8;
            this.ifEtapNotNull.Name = "ifEtapNotNull";
            // 
            // faultHandlerActivity2
            // 
            this.faultHandlerActivity2.Activities.Add(this.codeActivity3);
            this.faultHandlerActivity2.Activities.Add(this.logToHistoryListActivity3);
            this.faultHandlerActivity2.FaultType = typeof(System.SystemException);
            this.faultHandlerActivity2.Name = "faultHandlerActivity2";
            // 
            // faultHandlersActivity2
            // 
            this.faultHandlersActivity2.Activities.Add(this.faultHandlerActivity1);
            this.faultHandlersActivity2.Name = "faultHandlersActivity2";
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
            correlationtoken2.Name = "myToken";
            correlationtoken2.OwnerActivityName = "Workflow1";
            this.setState_Odrzucony.CorrelationToken = correlationtoken2;
            this.setState_Odrzucony.Name = "setState_Odrzucony";
            this.setState_Odrzucony.State = 16;
            // 
            // faultHandlersActivity9
            // 
            this.faultHandlersActivity9.Activities.Add(this.faultHandlerActivity6);
            this.faultHandlersActivity9.Name = "faultHandlersActivity9";
            // 
            // Telemarketing_Routing
            // 
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
            // logTEST1
            // 
            this.logTEST1.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logTEST1.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logTEST1.HistoryDescription = "TEST:Klient";
            activitybind18.Name = "Workflow1";
            activitybind18.Path = "logTEST_HistoryOutcome";
            this.logTEST1.Name = "logTEST1";
            this.logTEST1.OtherData = "";
            this.logTEST1.UserId = -1;
            this.logTEST1.MethodInvoking += new System.EventHandler(this.logTEST_MethodInvoking);
            this.logTEST1.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind18)));
            // 
            // onWorkflowItemChanged3
            // 
            this.onWorkflowItemChanged3.AfterProperties = null;
            this.onWorkflowItemChanged3.BeforeProperties = null;
            correlationtoken3.Name = "wtTelemarketing";
            correlationtoken3.OwnerActivityName = "Telemarketing";
            this.onWorkflowItemChanged3.CorrelationToken = correlationtoken3;
            this.onWorkflowItemChanged3.Name = "onWorkflowItemChanged3";
            this.onWorkflowItemChanged3.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            // 
            // initializeWorkflow2
            // 
            this.initializeWorkflow2.CorrelationToken = correlationtoken3;
            this.initializeWorkflow2.Name = "initializeWorkflow2";
            // 
            // setState_Telemarketing
            // 
            correlationtoken4.Name = "myToken";
            correlationtoken4.OwnerActivityName = "Workflow1";
            this.setState_Telemarketing.CorrelationToken = correlationtoken4;
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
            correlationtoken5.Name = "wtWeryfikacja";
            correlationtoken5.OwnerActivityName = "Weryfikacja";
            this.initializeWorkflow1.CorrelationToken = correlationtoken5;
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
            correlationtoken6.Name = "myToken";
            correlationtoken6.OwnerActivityName = "Workflow1";
            this.setState_Weryfikacja.CorrelationToken = correlationtoken6;
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
            // logTEST
            // 
            this.logTEST.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logTEST.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            this.logTEST.HistoryDescription = "TEST:Klient";
            activitybind19.Name = "Workflow1";
            activitybind19.Path = "logTEST_HistoryOutcome";
            this.logTEST.Name = "logTEST";
            this.logTEST.OtherData = "";
            this.logTEST.UserId = -1;
            this.logTEST.MethodInvoking += new System.EventHandler(this.logTEST_MethodInvoking);
            this.logTEST.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind19)));
            // 
            // onWorkflowItemChanged13
            // 
            this.onWorkflowItemChanged13.AfterProperties = null;
            this.onWorkflowItemChanged13.BeforeProperties = null;
            this.onWorkflowItemChanged13.CorrelationToken = correlationtoken5;
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
            this.faultHandlersActivity1.Activities.Add(this.faultHandlerActivity2);
            this.faultHandlersActivity1.Name = "faultHandlersActivity1";
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "Weryfikacja";
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
            this.onWorkflowActivated2.CorrelationToken = correlationtoken6;
            this.onWorkflowActivated2.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated2.Name = "onWorkflowActivated2";
            activitybind20.Name = "Workflow1";
            activitybind20.Path = "workflowProperties";
            this.onWorkflowActivated2.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.onWorkflowActivated1_Invoked);
            this.onWorkflowActivated2.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind20)));
            // 
            // stateInitializationActivity2
            // 
            this.stateInitializationActivity2.Activities.Add(this.setState_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.SetCT_Odrzucony);
            this.stateInitializationActivity2.Activities.Add(this.logToHistoryListActivity2);
            this.stateInitializationActivity2.Activities.Add(this.ifElseActivity1);
            this.stateInitializationActivity2.Activities.Add(this.setStateActivity26);
            this.stateInitializationActivity2.Activities.Add(this.faultHandlersActivity2);
            this.stateInitializationActivity2.Name = "stateInitializationActivity2";
            // 
            // Telemarketing_OnChange
            // 
            this.Telemarketing_OnChange.Activities.Add(this.onWorkflowItemChanged3);
            this.Telemarketing_OnChange.Activities.Add(this.logTEST1);
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
            this.Weryfikacja_OnChange.Activities.Add(this.logTEST);
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
            // Odrzucenie
            // 
            this.Odrzucenie.Activities.Add(this.stateInitializationActivity2);
            this.Odrzucenie.Name = "Odrzucenie";
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
            this.Activities.Add(this.Odrzucenie);
            this.Activities.Add(this.End);
            this.CompletedStateName = "End";
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "Start";
            this.Name = "Workflow1";
            this.CanModifyActivities = false;

        }

        #endregion

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logTEST1;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow1;

        private Microsoft.SharePoint.WorkflowActions.InitializeWorkflow initializeWorkflow2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logTEST;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity4;

        private CodeActivity codeActivity4;

        private FaultHandlerActivity faultHandlerActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity3;

        private CodeActivity codeActivity3;

        private FaultHandlerActivity faultHandlerActivity2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity1;

        private CodeActivity codeActivity2;

        private FaultHandlerActivity faultHandlerActivity1;

        private FaultHandlersActivity faultHandlersActivity2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity83;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logNavigator;

        private SetStateActivity setStateActivity32;

        private SetStateActivity setStateActivity30;

        private IfElseBranchActivity Else2;

        private IfElseBranchActivity ifOdrzucenie;

        private IfElseBranchActivity ifTelemarketing;

        private IfElseBranchActivity ifWeryfikacja;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity17;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendEmail_Stracony;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity58;

        private CodeActivity codeActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity71;

        private SetStateActivity setStateActivity10;

        private CodeActivity StatusTelefon_Stracony;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity34;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logERROR_NavigatorInit;

        private IfElseActivity Navigator_Routing_ver2;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity68;

        private IfElseBranchActivity Odrzucenie_MailSendAllowed;

        private FaultHandlerActivity faultHandlerActivity6;

        private IfElseBranchActivity ifElseBranchActivity2;

        private IfElseBranchActivity Telemarketing_Odrzucenie;

        private FaultHandlerActivity faultHandlerActivity3;

        private IfElseBranchActivity ifEtapNotNull;

        private SetStateActivity setStateActivity26;

        private IfElseActivity ifElseActivity1;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity2;

        private CodeActivity SetCT_Odrzucony;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Odrzucony;

        private FaultHandlersActivity faultHandlersActivity9;

        private IfElseActivity Telemarketing_Routing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity32;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged3;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Telemarketing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity16;

        private CodeActivity SetCT_Telemarketing;

        private FaultHandlersActivity faultHandlersActivity3;

        private IfElseActivity TestEtap;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logRouter;

        private FaultHandlersActivity faultHandlersActivity1;

        private SetStateActivity setStateActivity1;

        private CodeActivity codeSetup;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logZainicjowany;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated2;

        private StateInitializationActivity stateInitializationActivity2;

        private EventDrivenActivity Telemarketing_OnChange;

        private StateInitializationActivity stateInitializationActivity3;

        private StateInitializationActivity stateInitializationActivity15;

        private EventDrivenActivity eventDrivenActivity1;

        private StateActivity End;

        private StateActivity Odrzucenie;

        private StateActivity Telemarketing;

        private StateActivity Navigator;

        private StateActivity Start;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity57;

        private CodeActivity ErrorHandler_Weryfikacja;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity70;

        private SetStateActivity setStateActivity2;

        private CodeActivity StatusRozmowa_Stracony;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity31;

        private SetStateActivity setStateActivity4;

        private CodeActivity StatusRozmowa_Telefon;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity30;

        private FaultHandlerActivity faultHandlerActivity5;

        private IfElseBranchActivity ifElseBranchActivity1;

        private FaultHandlersActivity faultHandlersActivity6;

        private IfElseBranchActivity Weryfikacja_Odrzucenie;

        private IfElseBranchActivity Weryfikacja_Telemarketing;

        private FaultHandlersActivity faultHandlersActivity4;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity14;

        private Microsoft.SharePoint.WorkflowActions.SetState setState_Weryfikacja;

        private CodeActivity SetCT_Weryfikacja;

        private FaultHandlersActivity faultHandlersActivity5;

        private IfElseActivity Weryfikacja_Routing;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logToHistoryListActivity28;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged onWorkflowItemChanged13;

        private StateInitializationActivity stateInitializationActivity1;

        private EventDrivenActivity Weryfikacja_OnChange;

        private StateActivity Weryfikacja;

        private SetStateActivity setStateActivity28;











































































    }
}
