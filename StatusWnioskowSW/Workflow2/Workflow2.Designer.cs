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

namespace masterleasing.Reports.StatusWnioskowSW.Workflow2
{
    public sealed partial class Workflow2
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
            System.Workflow.ComponentModel.ActivityBind activitybind4 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind5 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Runtime.CorrelationToken correlationtoken1 = new System.Workflow.Runtime.CorrelationToken();
            System.Workflow.ComponentModel.ActivityBind activitybind6 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind7 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.ComponentModel.ActivityBind activitybind8 = new System.Workflow.ComponentModel.ActivityBind();
            this.logRaportWyslany = new Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity();
            this.sendRaportDlaAgenta = new Microsoft.SharePoint.WorkflowActions.SendEmail();
            this.ifZnalezioneKontrakty = new System.Workflow.Activities.IfElseBranchActivity();
            this.codeIncrementAgent = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.codeCreateReports = new System.Workflow.Activities.CodeActivity();
            this.codeResetFlags = new System.Workflow.Activities.CodeActivity();
            this.sequencePrzygotujRaport = new System.Workflow.Activities.SequenceActivity();
            this.whileAgentAvailable = new System.Workflow.Activities.WhileActivity();
            this.AgenciDoObslugi = new System.Workflow.Activities.IfElseBranchActivity();
            this.codeRemoveItem = new System.Workflow.Activities.CodeActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.codeGetTrybRaportu = new System.Workflow.Activities.CodeActivity();
            this.codeGetAgentDetails = new System.Workflow.Activities.CodeActivity();
            this.onWorkflowActivated1 = new Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated();
            // 
            // logRaportWyslany
            // 
            this.logRaportWyslany.Duration = System.TimeSpan.Parse("-10675199.02:48:05.4775808");
            this.logRaportWyslany.EventId = Microsoft.SharePoint.Workflow.SPWorkflowHistoryEventType.WorkflowComment;
            activitybind1.Name = "Workflow2";
            activitybind1.Path = "logHistoryDescription";
            activitybind2.Name = "Workflow2";
            activitybind2.Path = "logHistoryOutcome";
            this.logRaportWyslany.Name = "logRaportWyslany";
            this.logRaportWyslany.OtherData = "";
            this.logRaportWyslany.UserId = -1;
            this.logRaportWyslany.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryDescriptionProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.logRaportWyslany.SetBinding(Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity.HistoryOutcomeProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // sendRaportDlaAgenta
            // 
            activitybind3.Name = "Workflow2";
            activitybind3.Path = "sendBCC";
            activitybind4.Name = "Workflow2";
            activitybind4.Path = "sendBody";
            activitybind5.Name = "Workflow2";
            activitybind5.Path = "sendCC";
            correlationtoken1.Name = "workflowToken";
            correlationtoken1.OwnerActivityName = "Workflow2";
            this.sendRaportDlaAgenta.CorrelationToken = correlationtoken1;
            this.sendRaportDlaAgenta.From = null;
            this.sendRaportDlaAgenta.Headers = null;
            this.sendRaportDlaAgenta.IncludeStatus = false;
            this.sendRaportDlaAgenta.Name = "sendRaportDlaAgenta";
            activitybind6.Name = "Workflow2";
            activitybind6.Path = "sendSubject";
            activitybind7.Name = "Workflow2";
            activitybind7.Path = "sendTo";
            this.sendRaportDlaAgenta.MethodInvoking += new System.EventHandler(this.sendRaportDlaAgenta_MethodInvoking);
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.CCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind5)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.SubjectProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind6)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.ToProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind7)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BodyProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind4)));
            this.sendRaportDlaAgenta.SetBinding(Microsoft.SharePoint.WorkflowActions.SendEmail.BCCProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            // 
            // ifZnalezioneKontrakty
            // 
            this.ifZnalezioneKontrakty.Activities.Add(this.sendRaportDlaAgenta);
            this.ifZnalezioneKontrakty.Activities.Add(this.logRaportWyslany);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.hasZnalezioneKontrakty);
            this.ifZnalezioneKontrakty.Condition = codecondition1;
            this.ifZnalezioneKontrakty.Name = "ifZnalezioneKontrakty";
            // 
            // codeIncrementAgent
            // 
            this.codeIncrementAgent.Name = "codeIncrementAgent";
            this.codeIncrementAgent.ExecuteCode += new System.EventHandler(this.codeIncrementAgent_ExecuteCode);
            // 
            // ifElseActivity2
            // 
            this.ifElseActivity2.Activities.Add(this.ifZnalezioneKontrakty);
            this.ifElseActivity2.Name = "ifElseActivity2";
            // 
            // codeCreateReports
            // 
            this.codeCreateReports.Name = "codeCreateReports";
            this.codeCreateReports.ExecuteCode += new System.EventHandler(this.codeCreateReports_ExecuteCode);
            // 
            // codeResetFlags
            // 
            this.codeResetFlags.Name = "codeResetFlags";
            this.codeResetFlags.ExecuteCode += new System.EventHandler(this.codeResetFlags_ExecuteCode);
            // 
            // sequencePrzygotujRaport
            // 
            this.sequencePrzygotujRaport.Activities.Add(this.codeResetFlags);
            this.sequencePrzygotujRaport.Activities.Add(this.codeCreateReports);
            this.sequencePrzygotujRaport.Activities.Add(this.ifElseActivity2);
            this.sequencePrzygotujRaport.Activities.Add(this.codeIncrementAgent);
            this.sequencePrzygotujRaport.Name = "sequencePrzygotujRaport";
            // 
            // whileAgentAvailable
            // 
            this.whileAgentAvailable.Activities.Add(this.sequencePrzygotujRaport);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAgentAvailable);
            this.whileAgentAvailable.Condition = codecondition2;
            this.whileAgentAvailable.Name = "whileAgentAvailable";
            // 
            // AgenciDoObslugi
            // 
            this.AgenciDoObslugi.Activities.Add(this.whileAgentAvailable);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IsAgenciDoObslugi);
            this.AgenciDoObslugi.Condition = codecondition3;
            this.AgenciDoObslugi.Name = "AgenciDoObslugi";
            // 
            // codeRemoveItem
            // 
            this.codeRemoveItem.Name = "codeRemoveItem";
            this.codeRemoveItem.ExecuteCode += new System.EventHandler(this.codeRemoveItem_ExecuteCode);
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.AgenciDoObslugi);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // codeGetTrybRaportu
            // 
            this.codeGetTrybRaportu.Name = "codeGetTrybRaportu";
            this.codeGetTrybRaportu.ExecuteCode += new System.EventHandler(this.codeGetTrybRaportu_ExecuteCode);
            // 
            // codeGetAgentDetails
            // 
            this.codeGetAgentDetails.Name = "codeGetAgentDetails";
            this.codeGetAgentDetails.ExecuteCode += new System.EventHandler(this.codeGetAgentDetails_ExecuteCode);
            // 
            // onWorkflowActivated1
            // 
            this.onWorkflowActivated1.CorrelationToken = correlationtoken1;
            this.onWorkflowActivated1.EventName = "OnWorkflowActivated";
            this.onWorkflowActivated1.Name = "onWorkflowActivated1";
            activitybind8.Name = "Workflow2";
            activitybind8.Path = "workflowProperties";
            this.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind8)));
            // 
            // Workflow2
            // 
            this.Activities.Add(this.onWorkflowActivated1);
            this.Activities.Add(this.codeGetAgentDetails);
            this.Activities.Add(this.codeGetTrybRaportu);
            this.Activities.Add(this.ifElseActivity1);
            this.Activities.Add(this.codeRemoveItem);
            this.Name = "Workflow2";
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity codeResetFlags;

        private IfElseBranchActivity ifZnalezioneKontrakty;

        private IfElseActivity ifElseActivity2;

        private CodeActivity codeIncrementAgent;

        private Microsoft.SharePoint.WorkflowActions.LogToHistoryListActivity logRaportWyslany;

        private Microsoft.SharePoint.WorkflowActions.SendEmail sendRaportDlaAgenta;

        private CodeActivity codeCreateReports;

        private SequenceActivity sequencePrzygotujRaport;

        private WhileActivity whileAgentAvailable;

        private IfElseBranchActivity AgenciDoObslugi;

        private CodeActivity codeRemoveItem;

        private IfElseActivity ifElseActivity1;

        private CodeActivity codeGetTrybRaportu;

        private CodeActivity codeGetAgentDetails;

        private Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated onWorkflowActivated1;















    }
}
