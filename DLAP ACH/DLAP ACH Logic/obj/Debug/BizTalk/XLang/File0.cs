
#pragma warning disable 162

namespace DLAPACH
{

    [System.SerializableAttribute]
    sealed public class __DLAPACHDefinition_ACHRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHDefinition.ACHRequest _schema = new DLAPACHDefinition.ACHRequest();

        public __DLAPACHDefinition_ACHRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHDefinition.ACHRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHDefinition_ACHRequest__)
        },
        0,
        @"http://SBA.gov/DLAPACH/ACHRequestRequest#ACHRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class ACHRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHDefinition_ACHRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHDefinition_ACHRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public ACHRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHDefinition_ACHResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHDefinition.ACHResponse _schema = new DLAPACHDefinition.ACHResponse();

        public __DLAPACHDefinition_ACHResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHDefinition.ACHResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHDefinition_ACHResponse__)
        },
        0,
        @"http://SBA.gov/DLAPACH/ACHResponse#ACHResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class ACHResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHDefinition_ACHResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHDefinition_ACHResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public ACHResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHSalesforceDefinition_RestLoan_SaveRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHSalesforceDefinition.RestLoan.SaveRequest _schema = new DLAPACHSalesforceDefinition.RestLoan.SaveRequest();

        public __DLAPACHSalesforceDefinition_RestLoan_SaveRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHSalesforceDefinition.RestLoan.SaveRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHSalesforceDefinition_RestLoan_SaveRequest__)
        },
        0,
        @"http://SBA.gov/DLAPACH/REST/INSERT/Loan#SaveRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class RestLoanUpdateRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHSalesforceDefinition_RestLoan_SaveRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHSalesforceDefinition_RestLoan_SaveRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestLoanUpdateRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHSalesforceDefinition_RestLoan_results__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHSalesforceDefinition.RestLoan.results _schema = new DLAPACHSalesforceDefinition.RestLoan.results();

        public __DLAPACHSalesforceDefinition_RestLoan_results__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHSalesforceDefinition.RestLoan.results)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHSalesforceDefinition_RestLoan_results__)
        },
        0,
        @"http://SBA.gov/DLAPACH/REST/INSERT/Loan#results"
    )]
    [System.SerializableAttribute]
    sealed internal class RestLoanUpdateResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHSalesforceDefinition_RestLoan_results__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHSalesforceDefinition_RestLoan_results__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestLoanUpdateResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHDefinition_ACHFault__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHDefinition.ACHFault _schema = new DLAPACHDefinition.ACHFault();

        public __DLAPACHDefinition_ACHFault__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHDefinition.ACHFault)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHDefinition_ACHFault__)
        },
        0,
        @"http://SBA.gov/DLAPACH/ACHFault#Fault"
    )]
    [System.SerializableAttribute]
    sealed internal class ACHFaultResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHDefinition_ACHFault__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHDefinition_ACHFault__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public ACHFaultResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHSalesforceDefinition_RestLoanQuery_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHSalesforceDefinition.RestLoanQuery.Request _schema = new DLAPACHSalesforceDefinition.RestLoanQuery.Request();

        public __DLAPACHSalesforceDefinition_RestLoanQuery_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHSalesforceDefinition.RestLoanQuery.Request)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHSalesforceDefinition_RestLoanQuery_Request__)
        },
        0,
        @"http://SBA.gov/DLAPACH/REST/QUERY/Loan#Request"
    )]
    [System.SerializableAttribute]
    sealed internal class RestLoanQueryRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHSalesforceDefinition_RestLoanQuery_Request__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHSalesforceDefinition_RestLoanQuery_Request__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestLoanQueryRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHSalesforceDefinition_RestLoanQuery_QueryResult__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHSalesforceDefinition.RestLoanQuery.QueryResult _schema = new DLAPACHSalesforceDefinition.RestLoanQuery.QueryResult();

        public __DLAPACHSalesforceDefinition_RestLoanQuery_QueryResult__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHSalesforceDefinition.RestLoanQuery.QueryResult)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHSalesforceDefinition_RestLoanQuery_QueryResult__)
        },
        0,
        @"http://SBA.gov/DLAPACH/REST/QUERY/Loan#QueryResult"
    )]
    [System.SerializableAttribute]
    sealed internal class RestLoanQueryResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHSalesforceDefinition_RestLoanQuery_QueryResult__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHSalesforceDefinition_RestLoanQuery_QueryResult__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestLoanQueryResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHSalesforceDefinition_RestEventRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHSalesforceDefinition.RestEventRequest _schema = new DLAPACHSalesforceDefinition.RestEventRequest();

        public __DLAPACHSalesforceDefinition_RestEventRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHSalesforceDefinition.RestEventRequest)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHSalesforceDefinition_RestEventRequest__)
        },
        0,
        @"http://SBA.gov/DLAPACH/REST/INSERT/EventRequest#SaveRequest"
    )]
    [System.SerializableAttribute]
    sealed internal class RestEventRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHSalesforceDefinition_RestEventRequest__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHSalesforceDefinition_RestEventRequest__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestEventRequestType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DLAPACHSalesforceDefinition_RestEventResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DLAPACHSalesforceDefinition.RestEventResponse _schema = new DLAPACHSalesforceDefinition.RestEventResponse();

        public __DLAPACHSalesforceDefinition_RestEventResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(DLAPACHSalesforceDefinition.RestEventResponse)
        },
        new string[]{
            "MessagePart"
        },
        new System.Type[]{
            typeof(__DLAPACHSalesforceDefinition_RestEventResponse__)
        },
        0,
        @"http://SBA.gov/DLAPACH/REST/INSERT/EventResponse#results"
    )]
    [System.SerializableAttribute]
    sealed internal class RestEventResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DLAPACHSalesforceDefinition_RestEventResponse__ MessagePart;

        private void __CreatePartWrappers()
        {
            MessagePart = new __DLAPACHSalesforceDefinition_RestEventResponse__(this, "MessagePart", 0);
            this.AddPart("MessagePart", 0, MessagePart);
        }

        public RestEventResponseType(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPACH.ACHRequestType), 
            typeof(DLAPACH.ACHResponseType), 
            typeof(DLAPACH.ACHFaultResponseType)
        },
        new string[]{
            "Fault"
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ACHPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ACHPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ACHPortType(ACHPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ACHPortType p = new ACHPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(ACHPortType),
            typeof(ACHRequestType),
            typeof(ACHResponseType),
            new System.Type[]{
                typeof(ACHFaultResponseType)
            },
            new string[]{
                "Fault"
            }
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPACH.RestLoanQueryRequestType), 
            typeof(DLAPACH.RestLoanQueryResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestLoanQueryPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestLoanQueryPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestLoanQueryPortType(RestLoanQueryPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestLoanQueryPortType p = new RestLoanQueryPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestLoanQueryPortType),
            typeof(RestLoanQueryRequestType),
            typeof(RestLoanQueryResponseType),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPACH.RestLoanUpdateRequestType), 
            typeof(DLAPACH.RestLoanUpdateResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestLoanUpdatePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestLoanUpdatePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestLoanUpdatePortType(RestLoanUpdatePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestLoanUpdatePortType p = new RestLoanUpdatePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestLoanUpdatePortType),
            typeof(RestLoanUpdateRequestType),
            typeof(RestLoanUpdateResponseType),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DLAPACH.RestEventRequestType), 
            typeof(DLAPACH.RestEventResponseType)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class RestEventPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RestEventPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RestEventPortType(RestEventPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RestEventPortType p = new RestEventPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RestEventPortType),
            typeof(RestEventRequestType),
            typeof(RestEventResponseType),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 921 "C:\Users\Apudota\Documents\GitAzureRepo\DLAP ACH\DLAP ACH Logic\DLAP ACH Logic.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ACHPort", "Operation", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPACH.ACHPortType),
            typeof(DLAPACH.RestLoanQueryPortType),
            typeof(DLAPACH.RestLoanUpdatePortType)
        },
        new System.String[] {
            "ACHPort",
            "RestLoanQueryPort",
            "RestLoanUpdatePort"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(DLAPACH.EventRequest),
            typeof(DLAPACH.EventRequest)
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ProcessLogic : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
                "DLAPACH.EventRequest",
                "DLAPACH.EventRequest"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcessLogic));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ProcessLogic()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __ProcessLogic_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[5];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcessLogic(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcessLogic", tracker)
        {
            ConstructorHelper();
        }

        public ProcessLogic(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcessLogic")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>abc7952a-84d5-4381-80f3-f9bcf8e8c675</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>cadd4502-49eb-4c86-95af-06445e7946f6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive ACH Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>7ff5e61d-f3f9-40c1-8ff8-11620620bc42</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ACH Error Scope</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TaskShape</shapeType>      <ShapeID>3a93584e-2675-4242-8d56-0e2e2d385abf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ACH Loan Update Process</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>3c01a032-23e1-4523-99bc-591651f8ce43</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Loan Query Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>36b7afae-3333-468d-a89c-3bbb792109ea</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Loan Query Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2621f989-740b-4f7a-b6cf-29a4eb0d09b2</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>f1d9d9e4-437f-49ae-8c81-79467746fa92</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3e7df64c-01e7-4990-b927-295bfc56be7d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make SOQL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>49641a4e-c6f7-4cb4-bfba-d813c94633f4</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9dba8d47-f655-4096-a957-ba990def8e92</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Loan Query Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>181fbe45-a0a1-498f-91cd-4e42c9d2fd99</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Loan Query Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a1ac0205-4fa3-46e7-8872-73f67dfeb3b8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Rest Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>8b4dc74f-7a6b-4614-b960-6475a094586c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Valid Loan Name?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>e002039c-1012-4faa-b144-0bce1fc0ecb5</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Valid Loan</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>2fe45d13-4aa2-4716-ab4a-8e19f1c89fcb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct Update Loan Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>033bb38e-4cd2-4f26-bc6f-4abde9772fd2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Rest Loan Update Request</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d4a55c09-d2db-4143-a60c-bf5556c5b490</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2776f351-6645-4d22-8f29-abfd8eeb1f68</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>489003ad-2ff6-4261-b82b-85015185867b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Assgin Loan Id</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>6f7f414c-0bdb-4f2b-bfca-7acf1f233f3a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>64d4b83d-c21a-4a54-af72-18e6b64eb256</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Rest Update Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>07515f82-a111-432d-b9dc-027b732f2c90</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Rest Update Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>77f00183-29ed-4776-81b5-e06777fd6cc8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Extract Rest Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>a5883a29-9d55-4460-8878-23e81db123d1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Valid Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>964613da-5b09-4075-a101-0e76eace55a2</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5593b678-ee85-45c7-bcae-ee308c73c5b9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>7b15476c-9822-4549-a5dc-a13ee6955193</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Error </shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>a644aaed-5aeb-4b7a-9571-48dbd9de04a6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>c9f918d6-eb45-48dc-b5fc-37d9d14724a0</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ea91452c-dd75-47a3-9084-329cf9b020f6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct ACH Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f55b54ad-d767-43a6-86c6-ed7afb9ebbee</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>9d90bc9e-638c-489d-9bf7-0e8586cda413</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make ACH Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>4ec10053-fd84-4274-8f2e-9fda4d8c38e2</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5e46d074-ef53-4ef6-bfe2-5295dcac26b8</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>462a339b-636a-46ad-8e87-1860e00262d7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Event Log Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9a261f0e-f8cc-418f-a730-86e45916adff</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>bd4751cf-01e9-4cb2-90c5-18f999c34ff5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>df611774-b3c9-4c75-a4d6-77ac8ce485fd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Error </shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>ae0c07d8-7638-4050-b28b-7c900e6937c9</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>System Exception</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7a0a21bd-526c-4ee3-8492-b7c441cc11eb</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Set Error Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a87441ce-319a-40fc-8dc8-3dfdde667690</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Construct Document List Fault Response Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c41699bb-282f-4e42-aa3e-2270ee3f6da3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Document List Fault Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0638dd50-382c-4c8a-a2e1-4955502db0eb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4f4c30ee-1fc9-4c85-b1c8-03e8f23f8fcd</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send Fault</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>6a289592-292a-449f-adf8-1ec57eb9aec3</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>SFEventLog</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>44645fcf-9dcf-4c6c-be73-4bd2efbaeb99</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ApplicationNumber</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b247fb11-cb7c-4e83-8ebc-eddf7f5c3bf0</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>45132e77-2711-4929-872f-7391403f3f3e</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>c8fb1c7a-2e08-4088-bafe-04056d705c4d</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>bf3c2efb-463d-4287-8e25-44093e4a136c</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Stage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>ead9cacf-82d7-482e-8111-b4b66a200faa</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4c2ed16f-7bdc-46f0-81ba-d9d2c2080e26</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>60e2b8ed-a0c8-4b5f-83a5-6548d3b69a62</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>f00625f6-fce3-4de7-946a-2b71f25b7140</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Terminate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1bb8cca7-7f27-406c-a361-02c4650b3f39</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send ACH Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>a1aadc11-b5ff-419b-80b6-671761566cec</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Update Status?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>4ac4747e-ade0-4973-b849-ff40a516d8a1</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Success</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>46a62ed9-81e9-4a08-a075-a11f8fc20602</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Success Values For Salesforce</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>6904945b-14a2-408a-a485-7f1fe9431dd4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Fail</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>869d4e77-f6ba-43f6-87e0-7a9da82f67b2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Error Values For Salesforce</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>00dc84fe-0b78-4dbc-a75c-4bb74247320d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Call Event Log Orchestration</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>ef2d3ed0-ab72-44ae-9cc9-3559d5c1143b</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ApplicationNumber</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>5d13fbbe-fc36-4220-8369-1f2523432748</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>0778f653-b39e-4176-a17d-9f92a3628e03</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Message</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>a3182a42-bcaf-4769-8e5b-2bb8a32bd6ad</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>SalesForceObjectName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>8e3dc8c7-1d9a-495c-8c73-3ef556af2dee</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Stage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>54bd07e3-1c3a-434a-a633-130d507158cf</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Status</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>ee29dfe6-4196-4090-bfd5-85943057d727</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>Empty</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>35cedb3f-74fb-4e12-b8f6-5314b9b219e1</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcessLogic'</ActionName><IsAtomic>0</IsAtomic><Line>921</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>956</Line><Position>22</Position><ShapeID>'cadd4502-49eb-4c86-95af-06445e7946f6'</ShapeID>
<Messages>
	<MsgInfo><name>ACHRequestMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope36'</ActionName><IsAtomic>0</IsAtomic><Line>974</Line><Position>13</Position><ShapeID>'7ff5e61d-f3f9-40c1-8ff8-11620620bc42'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>979</Line><Position>21</Position><ShapeID>'3c01a032-23e1-4523-99bc-591651f8ce43'</ShapeID>
<Messages>
	<MsgInfo><name>RestLoanQueryRequestMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoanQuery+Request</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ACHRequestMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>994</Line><Position>21</Position><ShapeID>'9dba8d47-f655-4096-a957-ba990def8e92'</ShapeID>
<Messages>
	<MsgInfo><name>RestLoanQueryRequestMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoanQuery+Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>996</Line><Position>21</Position><ShapeID>'181fbe45-a0a1-498f-91cd-4e42c9d2fd99'</ShapeID>
<Messages>
	<MsgInfo><name>RestLoanQueryResponseMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoanQuery+QueryResult</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>999</Line><Position>34</Position><ShapeID>'a1ac0205-4fa3-46e7-8872-73f67dfeb3b8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1007</Line><Position>21</Position><ShapeID>'8b4dc74f-7a6b-4614-b960-6475a094586c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1010</Line><Position>25</Position><ShapeID>'2fe45d13-4aa2-4716-ab4a-8e19f1c89fcb'</ShapeID>
<Messages>
	<MsgInfo><name>RestLoanUpdateRequestMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoan+SaveRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>ACHRequestMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1018</Line><Position>25</Position><ShapeID>'64d4b83d-c21a-4a54-af72-18e6b64eb256'</ShapeID>
<Messages>
	<MsgInfo><name>RestLoanUpdateRequestMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoan+SaveRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1020</Line><Position>25</Position><ShapeID>'07515f82-a111-432d-b9dc-027b732f2c90'</ShapeID>
<Messages>
	<MsgInfo><name>RestLoanUpdateResponseMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoan+results</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1024</Line><Position>41</Position><ShapeID>'77f00183-29ed-4776-81b5-e06777fd6cc8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1031</Line><Position>25</Position><ShapeID>'a5883a29-9d55-4460-8878-23e81db123d1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1034</Line><Position>53</Position><ShapeID>'5593b678-ee85-45c7-bcae-ee308c73c5b9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1038</Line><Position>29</Position><ShapeID>'7b15476c-9822-4549-a5dc-a13ee6955193'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1040</Line><Position>29</Position><ShapeID>'a644aaed-5aeb-4b7a-9571-48dbd9de04a6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1043</Line><Position>25</Position><ShapeID>'ea91452c-dd75-47a3-9084-329cf9b020f6'</ShapeID>
<Messages>
	<MsgInfo><name>ACHResponseMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RestLoanUpdateResponseMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestLoan+results</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1049</Line><Position>49</Position><ShapeID>'462a339b-636a-46ad-8e87-1860e00262d7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1064</Line><Position>49</Position><ShapeID>'bd4751cf-01e9-4cb2-90c5-18f999c34ff5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1068</Line><Position>25</Position><ShapeID>'df611774-b3c9-4c75-a4d6-77ac8ce485fd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1074</Line><Position>21</Position><ShapeID>'ae0c07d8-7638-4050-b28b-7c900e6937c9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1077</Line><Position>25</Position><ShapeID>'7a0a21bd-526c-4ee3-8492-b7c441cc11eb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1129</Line><Position>25</Position><ShapeID>'a87441ce-319a-40fc-8dc8-3dfdde667690'</ShapeID>
<Messages>
	<MsgInfo><name>ACHFaultResponseMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHFault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1140</Line><Position>25</Position><ShapeID>'4f4c30ee-1fc9-4c85-b1c8-03e8f23f8fcd'</ShapeID>
<Messages>
	<MsgInfo><name>ACHFaultResponseMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHFault</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1142</Line><Position>51</Position><ShapeID>'6a289592-292a-449f-adf8-1ec57eb9aec3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1144</Line><Position>25</Position><ShapeID>'f00625f6-fce3-4de7-946a-2b71f25b7140'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1149</Line><Position>13</Position><ShapeID>'1bb8cca7-7f27-406c-a361-02c4650b3f39'</ShapeID>
<Messages>
	<MsgInfo><name>ACHResponseMsg</name><part>MessagePart</part><schema>DLAPACHDefinition.ACHResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1151</Line><Position>13</Position><ShapeID>'a1aadc11-b5ff-419b-80b6-671761566cec'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1156</Line><Position>25</Position><ShapeID>'46a62ed9-81e9-4a08-a075-a11f8fc20602'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1163</Line><Position>25</Position><ShapeID>'869d4e77-f6ba-43f6-87e0-7a9da82f67b2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1166</Line><Position>39</Position><ShapeID>'00dc84fe-0b78-4dbc-a75c-4bb74247320d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ee7f668c-d3a3-4fa8-9a12-af2501ad7acf' LowerBound='1.1' HigherBound='303.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPACH' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='39aa36a1-e851-4898-a1e5-0fb4505bf75f' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ACHPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='8da41934-377e-4ff1-8474-0a94f7d8ce77' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='ccd38ab7-9cb3-4e4b-9f78-808d271bc7b9' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.27'>
                    <om:Property Name='Ref' Value='DLAPACH.ACHRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='1e54c887-d02f-4147-8bc1-17d5893d63df' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='36.29' HigherBound='36.44'>
                    <om:Property Name='Ref' Value='DLAPACH.ACHResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d1793abf-ca5e-48be-b897-93d2a46ea300' ParentLink='OperationDeclaration_FaultMessageRef' LowerBound='36.46' HigherBound='36.74'>
                    <om:Property Name='Ref' Value='DLAPACH.ACHFaultResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Fault' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='33c0d771-7c5d-4558-8e33-00c60d33b106' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestLoanQueryPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='f3c8e290-b58b-4d92-9072-58bc02285e83' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d053d383-905d-45b2-b5d2-c3df860363b4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.37'>
                    <om:Property Name='Ref' Value='DLAPACH.RestLoanQueryRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='e9897af2-07f7-4c58-b882-6adebb81be0a' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='43.39' HigherBound='43.64'>
                    <om:Property Name='Ref' Value='DLAPACH.RestLoanQueryResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='cdebd251-fae0-44c8-8ec0-1ce8f7e2e199' ParentLink='Module_PortType' LowerBound='46.1' HigherBound='53.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestLoanUpdatePortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='c930612a-e246-452e-bce8-5e93d152974d' ParentLink='PortType_OperationDeclaration' LowerBound='48.1' HigherBound='52.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='97c0fd89-30ee-42a7-908a-5a53f417466c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='50.13' HigherBound='50.38'>
                    <om:Property Name='Ref' Value='DLAPACH.RestLoanUpdateRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='18645f0d-8ccc-4c5d-99ad-d0eab2728205' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='50.40' HigherBound='50.66'>
                    <om:Property Name='Ref' Value='DLAPACH.RestLoanUpdateResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='2332653f-b356-4e86-ae01-b186ff06c62e' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ACHRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='3d826da6-94d5-49eb-bb6d-701ed7fda867' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPACHDefinition.ACHRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='976f2b10-4d62-44bd-a089-546969ade784' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ACHResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='0d93cdb1-d9e1-4883-85f5-df16ed417ac4' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPACHDefinition.ACHResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='b694341e-d13e-45bb-9cb8-1b19536fd4ee' ParentLink='Module_MessageType' LowerBound='12.1' HigherBound='16.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestLoanUpdateRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='69e86f2c-a696-46bf-b621-e71817495da2' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='14.1' HigherBound='15.1'>
                <om:Property Name='ClassName' Value='DLAPACHSalesforceDefinition.RestLoan.SaveRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='13a2e393-e229-4e3a-a1e9-1486bf9b01b4' ParentLink='Module_MessageType' LowerBound='16.1' HigherBound='20.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestLoanUpdateResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e53957ea-3aa6-40d5-9c27-05a190d93676' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='ClassName' Value='DLAPACHSalesforceDefinition.RestLoan.results' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='cc47ca30-18d8-4c71-821a-c64b9f11c41e' ParentLink='Module_MessageType' LowerBound='20.1' HigherBound='24.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ACHFaultResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='5b76c900-f5f6-441e-b9fd-45db98a11524' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='ClassName' Value='DLAPACHDefinition.ACHFault' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='7bd27578-8a1a-4cdc-9a86-19c3588f19fc' ParentLink='Module_MessageType' LowerBound='24.1' HigherBound='28.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestLoanQueryRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='1a46fe86-7c47-4aff-babe-13c51ffe8653' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='ClassName' Value='DLAPACHSalesforceDefinition.RestLoanQuery.Request' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='1578026f-f4a0-4141-a099-f4b599675cfd' ParentLink='Module_MessageType' LowerBound='28.1' HigherBound='32.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestLoanQueryResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='e9a44bcf-d409-427a-8fd8-279297069075' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='ClassName' Value='DLAPACHSalesforceDefinition.RestLoanQuery.QueryResult' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='23298f27-79e1-4b53-8921-5d37551fc99a' ParentLink='Module_ServiceDeclaration' LowerBound='53.1' HigherBound='302.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcessLogic' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='518d5615-80ab-4be9-87bf-97a77e1961b2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Guid' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6d40e8a1-1cb5-40bd-8c8f-0bf10ffa6bf3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Status' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ba793c4b-1aac-477a-90ea-2ba1d3ebebf2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Stage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e09bbbf0-c6ad-4d42-a7b2-7968e569e2df' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApplicationNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dd5ab34a-82b9-491a-bb7a-1b90a22295c4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceObjectName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3307a3b8-b007-4035-ac40-ff8670c9e8c1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SalesForceObjectId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7ac4159f-4ed6-4dbc-b443-812d96171ac8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='75.1' HigherBound='76.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4ab09946-e561-4759-90b9-2e184474752f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='76.1' HigherBound='77.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LoanName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0f804338-9df2-493e-b4f0-5e0e92da348d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='77.1' HigherBound='78.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='22e499a9-a61a-4363-b0f2-7f5864428746' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='78.1' HigherBound='79.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempFaultResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='900e88a8-a933-4fbd-8420-5025928d1fbe' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='79.1' HigherBound='80.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Empty' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0789d444-8d05-427d-9240-dec44fccdd91' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='80.1' HigherBound='81.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LoanNameInfo' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4ee8c676-db16-4438-8efc-b6ad4b73f58e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='81.1' HigherBound='82.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SOQL_LoanInfo_QUERY' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0a49630b-db94-4b10-87b0-716e3e7b1009' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='82.1' HigherBound='83.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bcc01e46-4baa-45d7-a126-5473e5b4acee' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='83.1' HigherBound='84.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bacf388c-455e-4860-95f1-d9b800e7771d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='84.1' HigherBound='85.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanNameID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5c776587-b4f2-4cfa-9e1a-1a1d524a361a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='85.1' HigherBound='86.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanUpdateException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='267ae95e-8829-4ecf-8844-dc5680fc8b33' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='Type' Value='DLAPACH.ACHRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ACHRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d686e361-9093-482d-b41e-fab797c3666a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='Type' Value='DLAPACH.ACHResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ACHResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='920bf100-3a2a-48dd-9433-722913f3163d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='Type' Value='DLAPACH.RestLoanUpdateRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanUpdateRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='52fe076d-7df3-49af-8b2e-3566d1385731' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='Type' Value='DLAPACH.RestLoanUpdateResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanUpdateResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dac8242a-ac50-4adc-bdc1-2f375365cfef' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='Type' Value='DLAPACH.ACHFaultResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ACHFaultResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8bbde5e0-0056-4d87-b993-f9bc36a6078a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='Type' Value='DLAPACH.RestLoanQueryRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanQueryRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8c0b4af5-01bf-47d7-842f-082a731db71b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='Type' Value='DLAPACH.RestLoanQueryResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanQueryResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='abc7952a-84d5-4381-80f3-f9bcf8e8c675' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='cadd4502-49eb-4c86-95af-06445e7946f6' ParentLink='ServiceBody_Statement' LowerBound='88.1' HigherBound='106.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ACHPort' />
                    <om:Property Name='MessageName' Value='ACHRequestMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive ACH Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='7ff5e61d-f3f9-40c1-8ff8-11620620bc42' ParentLink='ServiceBody_Statement' LowerBound='106.1' HigherBound='281.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ACH Error Scope' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Task' OID='3a93584e-2675-4242-8d56-0e2e2d385abf' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='203.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ACH Loan Update Process' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='3c01a032-23e1-4523-99bc-591651f8ce43' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='126.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Loan Query Request Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='36b7afae-3333-468d-a89c-3bbb792109ea' ParentLink='ComplexStatement_Statement' LowerBound='114.1' HigherBound='116.1'>
                                <om:Property Name='ClassName' Value='DLAPACHLogic.MakeUpdateLoanRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Make Loan Query Request' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='2621f989-740b-4f7a-b6cf-29a4eb0d09b2' ParentLink='Transform_InputMessagePartRef' LowerBound='115.111' HigherBound='115.136'>
                                    <om:Property Name='MessageRef' Value='ACHRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='f1d9d9e4-437f-49ae-8c81-79467746fa92' ParentLink='Transform_OutputMessagePartRef' LowerBound='115.36' HigherBound='115.71'>
                                    <om:Property Name='MessageRef' Value='RestLoanQueryRequestMsg' />
                                    <om:Property Name='PartRef' Value='MessagePart' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='3e7df64c-01e7-4990-b927-295bfc56be7d' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='125.1'>
                                <om:Property Name='Expression' Value='//Construct SOQL Query&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;LoanNameInfo = xpath(ACHRequestMsg.MessagePart,&quot;string(/*[local-name()=&apos;ACHRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/ACHRequestRequest&apos;]/*[local-name()=&apos;LoanName&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;SOQL_LoanInfo_QUERY = @&quot;SELECT Id, Name,Application__r.Name FROM Loan__c WHERE Name IN &quot;+&quot;(&quot;+&quot;&apos;&quot;+LoanNameInfo+&quot;&apos;&quot;+&quot;)&quot;;&#xD;&#xA;&#xD;&#xA;RestLoanQueryRequestMsg(DLAPACHSalesforceDefinition.SOQL_LoanId_QUERY) = SOQL_LoanInfo_QUERY; &#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Make SOQL' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='49641a4e-c6f7-4cb4-bfba-d813c94633f4' ParentLink='Construct_MessageRef' LowerBound='112.31' HigherBound='112.54'>
                                <om:Property Name='Ref' Value='RestLoanQueryRequestMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='9dba8d47-f655-4096-a957-ba990def8e92' ParentLink='ComplexStatement_Statement' LowerBound='126.1' HigherBound='128.1'>
                            <om:Property Name='PortName' Value='RestLoanQueryPort' />
                            <om:Property Name='MessageName' Value='RestLoanQueryRequestMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Loan Query Request' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='181fbe45-a0a1-498f-91cd-4e42c9d2fd99' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='130.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='RestLoanQueryPort' />
                            <om:Property Name='MessageName' Value='RestLoanQueryResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Response' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Loan Query Response' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='a1ac0205-4fa3-46e7-8872-73f67dfeb3b8' ParentLink='ComplexStatement_Statement' LowerBound='130.1' HigherBound='139.1'>
                            <om:Property Name='Expression' Value='&#xD;&#xA;RestLoanSFID = xpath(RestLoanQueryResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;QueryResult&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;]/*[local-name()=&apos;records&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;]/*[local-name()=&apos;Id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;ApplicationNumber = xpath(RestLoanQueryResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;QueryResult&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;]/*[local-name()=&apos;records&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;]/*[local-name()=&apos;Application__r&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;]/*[local-name()=&apos;Name&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/QUERY/Loan&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Extract Rest Values' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Decision' OID='8b4dc74f-7a6b-4614-b960-6475a094586c' ParentLink='ComplexStatement_Statement' LowerBound='139.1' HigherBound='203.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Valid Loan Name?' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='e002039c-1012-4faa-b144-0bce1fc0ecb5' ParentLink='ReallyComplexStatement_Branch' LowerBound='140.21' HigherBound='194.1'>
                                <om:Property Name='Expression' Value='(!System.String.IsNullOrEmpty(RestLoanSFID))' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Valid Loan' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='2fe45d13-4aa2-4716-ab4a-8e19f1c89fcb' ParentLink='ComplexStatement_Statement' LowerBound='142.1' HigherBound='150.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct Update Loan Request Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='033bb38e-4cd2-4f26-bc6f-4abde9772fd2' ParentLink='ComplexStatement_Statement' LowerBound='145.1' HigherBound='147.1'>
                                        <om:Property Name='ClassName' Value='DLAPACHLogic.MakeRestLoanUpdateRequest' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make Rest Loan Update Request' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='d4a55c09-d2db-4143-a60c-bf5556c5b490' ParentLink='Transform_InputMessagePartRef' LowerBound='146.120' HigherBound='146.145'>
                                            <om:Property Name='MessageRef' Value='ACHRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_5' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='2776f351-6645-4d22-8f29-abfd8eeb1f68' ParentLink='Transform_OutputMessagePartRef' LowerBound='146.40' HigherBound='146.76'>
                                            <om:Property Name='MessageRef' Value='RestLoanUpdateRequestMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_6' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='489003ad-2ff6-4261-b82b-85015185867b' ParentLink='ComplexStatement_Statement' LowerBound='147.1' HigherBound='149.1'>
                                        <om:Property Name='Expression' Value='xpath(RestLoanUpdateRequestMsg.MessagePart,&quot;/*[local-name()=&apos;SaveRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;records&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;Id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]&quot;) = RestLoanSFID;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='Assgin Loan Id' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='6f7f414c-0bdb-4f2b-bfca-7acf1f233f3a' ParentLink='Construct_MessageRef' LowerBound='143.35' HigherBound='143.59'>
                                        <om:Property Name='Ref' Value='RestLoanUpdateRequestMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='64d4b83d-c21a-4a54-af72-18e6b64eb256' ParentLink='ComplexStatement_Statement' LowerBound='150.1' HigherBound='152.1'>
                                    <om:Property Name='PortName' Value='RestLoanUpdatePort' />
                                    <om:Property Name='MessageName' Value='RestLoanUpdateRequestMsg' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send Rest Update Request' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Receive' OID='07515f82-a111-432d-b9dc-027b732f2c90' ParentLink='ComplexStatement_Statement' LowerBound='152.1' HigherBound='154.1'>
                                    <om:Property Name='Activate' Value='False' />
                                    <om:Property Name='PortName' Value='RestLoanUpdatePort' />
                                    <om:Property Name='MessageName' Value='RestLoanUpdateResponseMsg' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Response' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Receive Rest Update Response' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='77f00183-29ed-4776-81b5-e06777fd6cc8' ParentLink='ComplexStatement_Statement' LowerBound='154.1' HigherBound='163.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;RestLoanMessage = xpath(RestLoanUpdateResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;errors&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;message&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;RestLoanNameID = xpath(RestLoanUpdateResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;]/*[local-name()=&apos;id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/Loan&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Extract Rest Values' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Decision' OID='a5883a29-9d55-4460-8878-23e81db123d1' ParentLink='ComplexStatement_Statement' LowerBound='163.1' HigherBound='175.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Valid Response' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='DecisionBranch' OID='964613da-5b09-4075-a101-0e76eace55a2' ParentLink='ReallyComplexStatement_Branch' LowerBound='164.25' HigherBound='175.1'>
                                        <om:Property Name='Expression' Value='!System.String.IsNullOrWhiteSpace(RestLoanMessage) &amp;&amp; (RestLoanNameID.Length == 0)' />
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Error' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='VariableAssignment' OID='5593b678-ee85-45c7-bcae-ee308c73c5b9' ParentLink='ComplexStatement_Statement' LowerBound='166.1' HigherBound='170.1'>
                                            <om:Property Name='Expression' Value='RestLoanUpdateException = new System.Exception(&quot;DLAP ACH Loan Update Rest Exception  -  &quot; + RestLoanMessage);&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Rest Exception' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Throw' OID='7b15476c-9822-4549-a5dc-a13ee6955193' ParentLink='ComplexStatement_Statement' LowerBound='170.1' HigherBound='172.1'>
                                            <om:Property Name='ThrownReference' Value='RestLoanUpdateException' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Rest Error ' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Terminate' OID='a644aaed-5aeb-4b7a-9571-48dbd9de04a6' ParentLink='ComplexStatement_Statement' LowerBound='172.1' HigherBound='174.1'>
                                            <om:Property Name='ErrorMessage' Value='&quot;An Exception occuered While Updating DLAP ACH Info&quot;;' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Terminate' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='DecisionBranch' OID='c9f918d6-eb45-48dc-b5fc-37d9d14724a0' ParentLink='ReallyComplexStatement_Branch'>
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Else' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Construct' OID='ea91452c-dd75-47a3-9084-329cf9b020f6' ParentLink='ComplexStatement_Statement' LowerBound='175.1' HigherBound='181.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct ACH Response Msg' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='f55b54ad-d767-43a6-86c6-ed7afb9ebbee' ParentLink='Construct_MessageRef' LowerBound='176.35' HigherBound='176.49'>
                                        <om:Property Name='Ref' Value='ACHResponseMsg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='Transform' OID='9d90bc9e-638c-489d-9bf7-0e8586cda413' ParentLink='ComplexStatement_Statement' LowerBound='178.1' HigherBound='180.1'>
                                        <om:Property Name='ClassName' Value='DLAPACHLogic.MakeACHResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Make ACH Response' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='4ec10053-fd84-4274-8f2e-9fda4d8c38e2' ParentLink='Transform_OutputMessagePartRef' LowerBound='179.40' HigherBound='179.66'>
                                            <om:Property Name='MessageRef' Value='ACHResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='5e46d074-ef53-4ef6-bfe2-5295dcac26b8' ParentLink='Transform_InputMessagePartRef' LowerBound='179.100' HigherBound='179.137'>
                                            <om:Property Name='MessageRef' Value='RestLoanUpdateResponseMsg' />
                                            <om:Property Name='PartRef' Value='MessagePart' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_3' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='462a339b-636a-46ad-8e87-1860e00262d7' ParentLink='ComplexStatement_Statement' LowerBound='181.1' HigherBound='193.1'>
                                    <om:Property Name='Expression' Value='OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;SalesForceObjectId = ACHRequestMsg.MessagePart.LoanName;&#xD;&#xA;&#xD;&#xA;SalesForceObjectName=&quot;Loan__c&quot;;&#xD;&#xA;&#xD;&#xA;Stage =&quot;ACH Received&quot;;&#xD;&#xA;&#xD;&#xA;Status = xpath(ACHResponseMsg.MessagePart, &quot;string(/*[local-name()=&apos;ACHResponse&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/ACHResponse&apos;]/*[local-name()=&apos;ACK&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;LoanName = xpath(ACHRequestMsg.MessagePart,&quot;string(/*[local-name()=&apos;ACHRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/ACHRequestRequest&apos;]/*[local-name()=&apos;LoanName&apos; and namespace-uri()=&apos;&apos;])&quot;);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Set Event Log Values' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='9a261f0e-f8cc-418f-a730-86e45916adff' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='bd4751cf-01e9-4cb2-90c5-18f999c34ff5' ParentLink='ComplexStatement_Statement' LowerBound='196.1' HigherBound='200.1'>
                                    <om:Property Name='Expression' Value='RestLoanUpdateException = new System.Exception(&quot;DLAP ACH Loan Query Rest Exception  -  &quot; +&quot;Loan Name not found in the Salesfroce&quot;);&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Rest Exception' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Throw' OID='df611774-b3c9-4c75-a4d6-77ac8ce485fd' ParentLink='ComplexStatement_Statement' LowerBound='200.1' HigherBound='202.1'>
                                    <om:Property Name='ThrownReference' Value='RestLoanUpdateException' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Rest Error ' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='ae0c07d8-7638-4050-b28b-7c900e6937c9' ParentLink='Scope_Catch' LowerBound='206.1' HigherBound='279.1'>
                        <om:Property Name='ExceptionName' Value='AEx' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='System Exception' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='7a0a21bd-526c-4ee3-8492-b7c441cc11eb' ParentLink='Catch_Statement' LowerBound='209.1' HigherBound='261.1'>
                            <om:Property Name='Expression' Value='if(AEx.InnerException != null)&#xD;&#xA;{&#xD;&#xA;MessageTemp = AEx.InnerException.ToString();&#xD;&#xA;&#xD;&#xA;Message = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP ACH Exception&quot;,Message);&#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;MessageTemp = AEx.Message.ToString();&#xD;&#xA;&#xD;&#xA;Message = MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900, MessageTemp.Length))) +&quot;Total String Length:&quot;+MessageTemp.Length.ToString();&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;DLAP ACH Exception&quot;,Message);&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;LoanName = xpath(ACHRequestMsg.MessagePart,&quot;string(/*[local-name()=&apos;ACHRequest&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/ACHRequestRequest&apos;]/*[local-name()=&apos;LoanName&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;if(!System.String.IsNullOrEmpty(ApplicationNumber))&#xD;&#xA;&#xD;&#xA;{&#xD;&#xA;  ApplicationNumber = ApplicationNumber;&#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;else{ApplicationNumber = &quot;NoAppNumber&quot;;  }&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;SalesForceObjectId = ACHRequestMsg.MessagePart.LoanName;&#xD;&#xA;&#xD;&#xA;SalesForceObjectName=&quot;Loan&quot;;&#xD;&#xA;&#xD;&#xA;Stage =&quot;ACH Received&quot;;&#xD;&#xA;&#xD;&#xA;Status = &quot;Error&quot;;&#xD;&#xA;&#xD;&#xA;OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Error Values' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Construct' OID='a87441ce-319a-40fc-8dc8-3dfdde667690' ParentLink='Catch_Statement' LowerBound='261.1' HigherBound='272.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct Document List Fault Response Msg' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='c41699bb-282f-4e42-aa3e-2270ee3f6da3' ParentLink='ComplexStatement_Statement' LowerBound='264.1' HigherBound='271.1'>
                                <om:Property Name='Expression' Value='TempFaultResponse = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;TempFaultResponse.LoadXml(System.String.Format(@&quot;&lt;ns0:Fault xmlns:ns0=&apos;http://SBA.gov/DLAPACH/ACHFault&apos;&gt;&lt;FaultString&gt;Exception:DLAP ACH&lt;/FaultString&gt;&lt;FaultCode&gt;{0}&lt;/FaultCode&gt;&lt;/ns0:Fault&gt;&quot;,System.Security.SecurityElement.Escape(Message)));&#xD;&#xA;&#xD;&#xA;ACHFaultResponseMsg.MessagePart = TempFaultResponse;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Document List Fault Response' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='0638dd50-382c-4c8a-a2e1-4955502db0eb' ParentLink='Construct_MessageRef' LowerBound='262.35' HigherBound='262.54'>
                                <om:Property Name='Ref' Value='ACHFaultResponseMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='4f4c30ee-1fc9-4c85-b1c8-03e8f23f8fcd' ParentLink='Catch_Statement' LowerBound='272.1' HigherBound='274.1'>
                            <om:Property Name='PortName' Value='ACHPort' />
                            <om:Property Name='MessageName' Value='ACHFaultResponseMsg' />
                            <om:Property Name='OperationName' Value='Operation' />
                            <om:Property Name='OperationMessageName' Value='Fault' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Fault' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Call' OID='6a289592-292a-449f-adf8-1ec57eb9aec3' ParentLink='Catch_Statement' LowerBound='274.1' HigherBound='276.1'>
                            <om:Property Name='Identifier' Value='CallOrchestration_2' />
                            <om:Property Name='Invokee' Value='DLAPACH.EventRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='SFEventLog' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Parameter' OID='44645fcf-9dcf-4c6c-be73-4bd2efbaeb99' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='ApplicationNumber' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='b247fb11-cb7c-4e83-8ebc-eddf7f5c3bf0' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SalesForceObjectId' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='45132e77-2711-4929-872f-7391403f3f3e' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Message' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='c8fb1c7a-2e08-4088-bafe-04056d705c4d' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='SalesForceObjectName' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='bf3c2efb-463d-4287-8e25-44093e4a136c' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Stage' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='ead9cacf-82d7-482e-8111-b4b66a200faa' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Status' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='4c2ed16f-7bdc-46f0-81ba-d9d2c2080e26' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='Empty' />
                                <om:Property Name='Type' Value='System.String' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Parameter' OID='60e2b8ed-a0c8-4b5f-83a5-6548d3b69a62' ParentLink='InvokeStatement_Parameter'>
                                <om:Property Name='Direction' Value='In' />
                                <om:Property Name='Name' Value='OrchestrationInstanceId' />
                                <om:Property Name='Type' Value='System.Guid' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Terminate' OID='f00625f6-fce3-4de7-946a-2b71f25b7140' ParentLink='Catch_Statement' LowerBound='276.1' HigherBound='278.1'>
                            <om:Property Name='ErrorMessage' Value='&quot;An error occurred while processing the DLAP ACH&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='1bb8cca7-7f27-406c-a361-02c4650b3f39' ParentLink='ServiceBody_Statement' LowerBound='281.1' HigherBound='283.1'>
                    <om:Property Name='PortName' Value='ACHPort' />
                    <om:Property Name='MessageName' Value='ACHResponseMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send ACH Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='a1aadc11-b5ff-419b-80b6-671761566cec' ParentLink='ServiceBody_Statement' LowerBound='283.1' HigherBound='298.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Update Status?' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='4ac4747e-ade0-4973-b849-ff40a516d8a1' ParentLink='ReallyComplexStatement_Branch' LowerBound='284.13' HigherBound='291.1'>
                        <om:Property Name='Expression' Value='Status == &quot;Success&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Success' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='46a62ed9-81e9-4a08-a075-a11f8fc20602' ParentLink='ComplexStatement_Statement' LowerBound='286.1' HigherBound='290.1'>
                            <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;Message = &quot;Successfully Updated LoanName:&quot;+LoanName;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Success Values For Salesforce' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='6904945b-14a2-408a-a485-7f1fe9431dd4' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Fail' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='869d4e77-f6ba-43f6-87e0-7a9da82f67b2' ParentLink='ComplexStatement_Statement' LowerBound='293.1' HigherBound='297.1'>
                            <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;Message = &quot;Error Occured Updating LoanName:&quot;+LoanName;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Error Values For Salesforce' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Call' OID='00dc84fe-0b78-4dbc-a75c-4bb74247320d' ParentLink='ServiceBody_Statement' LowerBound='298.1' HigherBound='300.1'>
                    <om:Property Name='Identifier' Value='CallOrchestration_1' />
                    <om:Property Name='Invokee' Value='DLAPACH.EventRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Call Event Log Orchestration' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Parameter' OID='ef2d3ed0-ab72-44ae-9cc9-3559d5c1143b' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='ApplicationNumber' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='5d13fbbe-fc36-4220-8369-1f2523432748' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='SalesForceObjectId' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='0778f653-b39e-4176-a17d-9f92a3628e03' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Message' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='a3182a42-bcaf-4769-8e5b-2bb8a32bd6ad' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='SalesForceObjectName' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='8e3dc8c7-1d9a-495c-8c73-3ef556af2dee' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Stage' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='54bd07e3-1c3a-434a-a633-130d507158cf' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Status' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='ee29dfe6-4196-4090-bfd5-85943057d727' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='Empty' />
                        <om:Property Name='Type' Value='System.String' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Parameter' OID='35cedb3f-74fb-4e12-b8f6-5314b9b219e1' ParentLink='InvokeStatement_Parameter'>
                        <om:Property Name='Direction' Value='In' />
                        <om:Property Name='Name' Value='OrchestrationInstanceId' />
                        <om:Property Name='Type' Value='System.Guid' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='983671a4-b9f9-49c8-84c6-7c253c1a2098' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='56.1' HigherBound='58.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPACH.ACHPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ACHPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='86501777-7a66-41c9-9fe3-06f6cd3a6458' ParentLink='PortDeclaration_CLRAttribute' LowerBound='56.1' HigherBound='57.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4b7aa242-a4f5-4b6e-93fa-4761e585e272' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='58.1' HigherBound='60.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPACH.RestLoanQueryPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanQueryPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='54503ab5-cf42-4408-8363-e59aded482d1' ParentLink='PortDeclaration_CLRAttribute' LowerBound='58.1' HigherBound='59.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='04e5f4fb-342c-4348-9ef1-cc60264a1fdd' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='60.1' HigherBound='62.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='53' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPACH.RestLoanUpdatePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestLoanUpdatePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7831b5ed-4755-4903-9df6-7a0636faae43' ParentLink='PortDeclaration_CLRAttribute' LowerBound='60.1' HigherBound='61.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcessLogic_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcessLogic_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessLogic")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessLogic __svc__ = (ProcessLogic)_service;
                __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RestLoanUpdatePort != null)
                {
                    __svc__.RestLoanUpdatePort.Close(this, null);
                    __svc__.RestLoanUpdatePort = null;
                }
                if (__svc__.RestLoanQueryPort != null)
                {
                    __svc__.RestLoanQueryPort.Close(this, null);
                    __svc__.RestLoanQueryPort = null;
                }
                if (__svc__.ACHPort != null)
                {
                    __svc__.ACHPort.Close(this, null);
                    __svc__.ACHPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
        }


        [System.SerializableAttribute]
        public class __ProcessLogic_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ProcessLogic_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcessLogic")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessLogic __svc__ = (ProcessLogic)_service;
                __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__RestLoanUpdateException = null;
                if (__ctx1__ != null)
                    __ctx1__.__LoanNameInfo = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectId = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectName = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempFaultResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                if (__ctx1__ != null && __ctx1__.__ACHRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ACHRequestMsg);
                    __ctx1__.__ACHRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null)
                    __ctx1__.__LoanName = null;
                if (__ctx1__ != null)
                    __ctx1__.__Empty = null;
                if (__ctx1__ != null)
                    __ctx1__.__SOQL_LoanInfo_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanNameID = null;
                if (__ctx1__ != null && __ctx1__.__ACHResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ACHResponseMsg);
                    __ctx1__.__ACHResponseMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ACHRequestMsg")]
            internal ACHRequestType __ACHRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ACHResponseMsg")]
            internal ACHResponseType __ACHResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanUpdateRequestMsg")]
            internal RestLoanUpdateRequestType __RestLoanUpdateRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanUpdateResponseMsg")]
            internal RestLoanUpdateResponseType __RestLoanUpdateResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ACHFaultResponseMsg")]
            internal ACHFaultResponseType __ACHFaultResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanQueryRequestMsg")]
            internal RestLoanQueryRequestType __RestLoanQueryRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanQueryResponseMsg")]
            internal RestLoanQueryResponseType __RestLoanQueryResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceId")]
            internal System.Guid __OrchestrationInstanceId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Status")]
            internal System.String __Status;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Stage")]
            internal System.String __Stage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApplicationNumber")]
            internal System.String __ApplicationNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceObjectName")]
            internal System.String __SalesForceObjectName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SalesForceObjectId")]
            internal System.String __SalesForceObjectId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message")]
            internal System.String __Message;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LoanName")]
            internal System.String __LoanName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageTemp")]
            internal System.String __MessageTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempFaultResponse")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempFaultResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Empty")]
            internal System.String __Empty;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LoanNameInfo")]
            internal System.String __LoanNameInfo;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SOQL_LoanInfo_QUERY")]
            internal System.String __SOQL_LoanInfo_QUERY;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanSFID")]
            internal System.String __RestLoanSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanMessage")]
            internal System.String __RestLoanMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanNameID")]
            internal System.String __RestLoanNameID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanUpdateException")]
            internal System.Exception __RestLoanUpdateException;
        }


        [System.SerializableAttribute]
        public class ____scope36_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope36_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope36")
            {
            }

            public override int Index { get { return 2; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcessLogic __svc__ = (ProcessLogic)_service;
                ____scope36_2 __ctx2__ = (____scope36_2)(__svc__._stateMgrs[2]);
                __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)(__svc__._stateMgrs[0]);
                __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__RestLoanUpdateRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanUpdateRequestMsg);
                    __ctx1__.__RestLoanUpdateRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestLoanQueryRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanQueryRequestMsg);
                    __ctx1__.__RestLoanQueryRequestMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestLoanQueryResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanQueryResponseMsg);
                    __ctx1__.__RestLoanQueryResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__RestLoanUpdateResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanUpdateResponseMsg);
                    __ctx1__.__RestLoanUpdateResponseMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__ACHFaultResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ACHFaultResponseMsg);
                    __ctx1__.__ACHFaultResponseMsg = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__AEx_0 = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __AEx_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ACHPort")]
        internal ACHPortType ACHPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanQueryPort")]
        internal RestLoanQueryPortType RestLoanQueryPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestLoanUpdatePort")]
        internal RestLoanUpdatePortType RestLoanUpdatePort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ACHPortType.Operation},
                                               typeof(ProcessLogic).GetField("ACHPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessLogic), "ACHPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestLoanQueryPortType.Operation},
                                               typeof(ProcessLogic).GetField("RestLoanQueryPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessLogic), "RestLoanQueryPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestLoanUpdatePortType.Operation},
                                               typeof(ProcessLogic).GetField("RestLoanUpdatePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcessLogic), "RestLoanUpdatePort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                    typeof(DLAPACH.EventRequest)                    
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "cadd4502-49eb-4c86-95af-06445e7946f6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "cadd4502-49eb-4c86-95af-06445e7946f6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "7ff5e61d-f3f9-40c1-8ff8-11620620bc42", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "3c01a032-23e1-4523-99bc-591651f8ce43", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "3c01a032-23e1-4523-99bc-591651f8ce43", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9dba8d47-f655-4096-a957-ba990def8e92", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9dba8d47-f655-4096-a957-ba990def8e92", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "181fbe45-a0a1-498f-91cd-4e42c9d2fd99", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "181fbe45-a0a1-498f-91cd-4e42c9d2fd99", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "a1ac0205-4fa3-46e7-8872-73f67dfeb3b8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "a1ac0205-4fa3-46e7-8872-73f67dfeb3b8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "8b4dc74f-7a6b-4614-b960-6475a094586c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "2fe45d13-4aa2-4716-ab4a-8e19f1c89fcb", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "2fe45d13-4aa2-4716-ab4a-8e19f1c89fcb", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "64d4b83d-c21a-4a54-af72-18e6b64eb256", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "64d4b83d-c21a-4a54-af72-18e6b64eb256", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "07515f82-a111-432d-b9dc-027b732f2c90", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "07515f82-a111-432d-b9dc-027b732f2c90", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "77f00183-29ed-4776-81b5-e06777fd6cc8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "77f00183-29ed-4776-81b5-e06777fd6cc8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "a5883a29-9d55-4460-8878-23e81db123d1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "5593b678-ee85-45c7-bcae-ee308c73c5b9", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "5593b678-ee85-45c7-bcae-ee308c73c5b9", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "7b15476c-9822-4549-a5dc-a13ee6955193", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "a644aaed-5aeb-4b7a-9571-48dbd9de04a6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "a5883a29-9d55-4460-8878-23e81db123d1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "ea91452c-dd75-47a3-9084-329cf9b020f6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "ea91452c-dd75-47a3-9084-329cf9b020f6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "462a339b-636a-46ad-8e87-1860e00262d7", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "462a339b-636a-46ad-8e87-1860e00262d7", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "bd4751cf-01e9-4cb2-90c5-18f999c34ff5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "bd4751cf-01e9-4cb2-90c5-18f999c34ff5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "df611774-b3c9-4c75-a4d6-77ac8ce485fd", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "8b4dc74f-7a6b-4614-b960-6475a094586c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "ae0c07d8-7638-4050-b28b-7c900e6937c9", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "7a0a21bd-526c-4ee3-8492-b7c441cc11eb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "7a0a21bd-526c-4ee3-8492-b7c441cc11eb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "a87441ce-319a-40fc-8dc8-3dfdde667690", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "a87441ce-319a-40fc-8dc8-3dfdde667690", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "4f4c30ee-1fc9-4c85-b1c8-03e8f23f8fcd", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "4f4c30ee-1fc9-4c85-b1c8-03e8f23f8fcd", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "6a289592-292a-449f-adf8-1ec57eb9aec3", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "6a289592-292a-449f-adf8-1ec57eb9aec3", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "f00625f6-fce3-4de7-946a-2b71f25b7140", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "ae0c07d8-7638-4050-b28b-7c900e6937c9", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "7ff5e61d-f3f9-40c1-8ff8-11620620bc42", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "1bb8cca7-7f27-406c-a361-02c4650b3f39", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "1bb8cca7-7f27-406c-a361-02c4650b3f39", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "a1aadc11-b5ff-419b-80b6-671761566cec", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "46a62ed9-81e9-4a08-a075-a11f8fc20602", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "46a62ed9-81e9-4a08-a075-a11f8fc20602", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "869d4e77-f6ba-43f6-87e0-7a9da82f67b2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "869d4e77-f6ba-43f6-87e0-7a9da82f67b2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "a1aadc11-b5ff-419b-80b6-671761566cec", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "00dc84fe-0b78-4dbc-a75c-4bb74247320d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "00dc84fe-0b78-4dbc-a75c-4bb74247320d", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,4,51,52,52,52,53,54,54,55,55,56,54,57,57,58,59,60,60,61,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,8,8,9,10,10,11,12,12,13,13,13,15,15,16,16,17,18,18,18,19,20,20,21,22,22,23,23,24,24,25,25,26,26,27,27,28,28,29,30,30,31,32,32,33,33,33,33,33,33,15,34,34,35,35,36,36,37,37,37,37,};
        public static int[] __progressLocation3 = new int[] { 38,38,39,39,39,39,39,39,39,39,39,42,42,42,42,42,42,42,42,42,42,42,42,42,43,43,44,45,45,45,46,47,47,48,49,49,50,50,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ACHPort = new ACHPortType(0, this);
                RestLoanQueryPort = new RestLoanQueryPortType(1, this);
                RestLoanUpdatePort = new RestLoanUpdatePortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ACHPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcessLogic_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            ____scope36_2 __ctx2__ = (____scope36_2)_stateMgrs[2];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__OrchestrationInstanceId = default(System.Guid);
                __ctx1__.__Status = default(System.String);
                __ctx1__.__Stage = default(System.String);
                __ctx1__.__ApplicationNumber = default(System.String);
                __ctx1__.__SalesForceObjectName = default(System.String);
                __ctx1__.__SalesForceObjectId = default(System.String);
                __ctx1__.__Message = default(System.String);
                __ctx1__.__LoanName = default(System.String);
                __ctx1__.__MessageTemp = default(System.String);
                __ctx1__.__TempFaultResponse = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__Empty = default(System.String);
                __ctx1__.__LoanNameInfo = default(System.String);
                __ctx1__.__SOQL_LoanInfo_QUERY = default(System.String);
                __ctx1__.__RestLoanSFID = default(System.String);
                __ctx1__.__RestLoanMessage = default(System.String);
                __ctx1__.__RestLoanNameID = default(System.String);
                __ctx1__.__RestLoanUpdateException = default(System.Exception);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ACHPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__ACHRequestMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ACHRequestMsg);
                __ctx1__.__ACHRequestMsg = new ACHRequestType("ACHRequestMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__ACHRequestMsg);
                ACHPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__ACHRequestMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__ACHRequestMsg);
                    __edata.PortName = @"ACHPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__Status = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__Stage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ApplicationNumber = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__SalesForceObjectName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__SalesForceObjectId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__Message = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__LoanName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__MessageTemp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__TempFaultResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__Empty = "";
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__LoanNameInfo = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__SOQL_LoanInfo_QUERY = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__RestLoanSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__RestLoanMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__RestLoanNameID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__RestLoanUpdateException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                __ctx2__ = new ____scope36_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanUpdateException = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanNameID = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestLoanSFID = null;
                if (__ctx1__ != null)
                    __ctx1__.__SOQL_LoanInfo_QUERY = null;
                if (__ctx1__ != null)
                    __ctx1__.__LoanNameInfo = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempFaultResponse = null;
                if (__ctx1__ != null)
                    __ctx1__.__MessageTemp = null;
                if (__ctx1__ != null && __ctx1__.__ACHRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ACHRequestMsg);
                    __ctx1__.__ACHRequestMsg = null;
                }
                if (RestLoanUpdatePort != null)
                {
                    RestLoanUpdatePort.Close(__ctx1__, __seg__);
                    RestLoanUpdatePort = null;
                }
                if (RestLoanQueryPort != null)
                {
                    RestLoanQueryPort.Close(__ctx1__, __seg__);
                    RestLoanQueryPort = null;
                }
                Tracker.FireEvent(__eventLocations[51],__eventData[15],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[52],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ACHPort.SendMessage(0, __ctx1__.__ACHResponseMsg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (ACHPort != null)
                {
                    ACHPort.Close(__ctx1__, __seg__);
                    ACHPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ACHResponseMsg);
                    __edata.PortName = @"ACHPort";
                    Tracker.FireEvent(__eventLocations[53],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ACHResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ACHResponseMsg);
                    __ctx1__.__ACHResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[54],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __condition__ = __ctx1__.__Status == "Success";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 35;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__Message = "Successfully Updated LoanName:" + __ctx1__.__LoanName;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[56],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[57],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                __ctx1__.__Message = "Error Occured Updating LoanName:" + __ctx1__.__LoanName;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                Tracker.FireEvent(__eventLocations[58],__eventData[6],_stateMgrs[1].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__LoanName = null;
                Tracker.FireEvent(__eventLocations[59],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[60],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPACH.EventRequest(4, InstanceId, this);
                    _stateMgrs[4] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[60],new object[] {__ctx1__.__ApplicationNumber, __ctx1__.__SalesForceObjectId, __ctx1__.__Message, __ctx1__.__SalesForceObjectName, __ctx1__.__Stage, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[4]).Args;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Empty = null;
                if (__ctx1__ != null)
                    __ctx1__.__Message = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectId = null;
                if (__ctx1__ != null)
                    __ctx1__.__SalesForceObjectName = null;
                if (__ctx1__ != null)
                    __ctx1__.__ApplicationNumber = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage = null;
                if (__ctx1__ != null)
                    __ctx1__.__Status = null;
                Tracker.FireEvent(__eventLocations[61],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[16],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 45;
            case 45:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope36_2 __ctx2__ = (____scope36_2)_stateMgrs[2];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    RestLoanQueryRequestType __RestLoanQueryRequestMsg = new RestLoanQueryRequestType("RestLoanQueryRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPACHLogic.MakeUpdateLoanRequest), new object[] {__RestLoanQueryRequestMsg.MessagePart}, new object[] {__ctx1__.__ACHRequestMsg.MessagePart});
                    __ctx1__.__LoanNameInfo = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ACHRequestMsg.MessagePart, "string(/*[local-name()='ACHRequest' and namespace-uri()='http://SBA.gov/DLAPACH/ACHRequestRequest']/*[local-name()='LoanName' and namespace-uri()=''])", typeof(System.String));
                    __ctx1__.__SOQL_LoanInfo_QUERY = @"SELECT Id, Name,Application__r.Name FROM Loan__c WHERE Name IN " + "(" + "'" + __ctx1__.__LoanNameInfo + "'" + ")";
                    __RestLoanQueryRequestMsg.SetPropertyValue(typeof(DLAPACHSalesforceDefinition.SOQL_LoanId_QUERY), __ctx1__.__SOQL_LoanInfo_QUERY);

                    if (__ctx1__.__RestLoanQueryRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestLoanQueryRequestMsg);
                    __ctx1__.__RestLoanQueryRequestMsg = __RestLoanQueryRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestLoanQueryRequestMsg);
                }
                __ctx1__.__RestLoanQueryRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestLoanQueryRequestMsg);
                    __edata.Messages.Add(__ctx1__.__ACHRequestMsg);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestLoanQueryPort.SendMessage(0, __ctx1__.__RestLoanQueryRequestMsg, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestLoanQueryRequestMsg);
                    __edata.PortName = @"RestLoanQueryPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestLoanQueryRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanQueryRequestMsg);
                    __ctx1__.__RestLoanQueryRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!RestLoanQueryPort.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__RestLoanQueryResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanQueryResponseMsg);
                __ctx1__.__RestLoanQueryResponseMsg = new RestLoanQueryResponseType("RestLoanQueryResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestLoanQueryResponseMsg);
                RestLoanQueryPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestLoanQueryResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestLoanQueryResponseMsg);
                    __edata.PortName = @"RestLoanQueryPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__RestLoanSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestLoanQueryResponseMsg.MessagePart, "string(/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__ApplicationNumber = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestLoanQueryResponseMsg.MessagePart, "string(/*[local-name()='QueryResult' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan']/*[local-name()='Application__r' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan']/*[local-name()='Name' and namespace-uri()='http://SBA.gov/DLAPACH/REST/QUERY/Loan'])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__RestLoanQueryResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanQueryResponseMsg);
                    __ctx1__.__RestLoanQueryResponseMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __condition__ = (!System.String.IsNullOrEmpty(__ctx1__.__RestLoanSFID));
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 55;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    RestLoanUpdateRequestType __RestLoanUpdateRequestMsg = new RestLoanUpdateRequestType("RestLoanUpdateRequestMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPACHLogic.MakeRestLoanUpdateRequest), new object[] {__RestLoanUpdateRequestMsg.MessagePart}, new object[] {__ctx1__.__ACHRequestMsg.MessagePart});
                    __RestLoanUpdateRequestMsg.MessagePart.XPathStore(__ctx1__.__RestLoanSFID, "/*[local-name()='SaveRequest' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='records' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='Id' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']");

                    if (__ctx1__.__RestLoanUpdateRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestLoanUpdateRequestMsg);
                    __ctx1__.__RestLoanUpdateRequestMsg = __RestLoanUpdateRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestLoanUpdateRequestMsg);
                }
                __ctx1__.__RestLoanUpdateRequestMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestLoanUpdateRequestMsg);
                    __edata.Messages.Add(__ctx1__.__ACHRequestMsg);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestLoanUpdatePort.SendMessage(0, __ctx1__.__RestLoanUpdateRequestMsg, null, null, out __ctx0__.__subWrapper2, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestLoanUpdateRequestMsg);
                    __edata.PortName = @"RestLoanUpdatePort";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestLoanUpdateRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanUpdateRequestMsg);
                    __ctx1__.__RestLoanUpdateRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if (!RestLoanUpdatePort.GetMessageId(__ctx0__.__subWrapper2.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx1__.__RestLoanUpdateResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanUpdateResponseMsg);
                __ctx1__.__RestLoanUpdateResponseMsg = new RestLoanUpdateResponseType("RestLoanUpdateResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestLoanUpdateResponseMsg);
                RestLoanUpdatePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestLoanUpdateResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestLoanUpdateResponseMsg);
                    __edata.PortName = @"RestLoanUpdatePort";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                __ctx1__.__RestLoanMessage = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestLoanUpdateResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='message' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                __ctx1__.__RestLoanNameID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestLoanUpdateResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan']/*[local-name()='id' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/Loan'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__RestLoanMessage) && (__ctx1__.__RestLoanNameID.Length == 0);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 42;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                __ctx1__.__RestLoanUpdateException = new System.Exception("DLAP ACH Loan Update Rest Exception  -  " + __ctx1__.__RestLoanMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                throw __ctx1__.__RestLoanUpdateException;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                RequestTerminate(__ctx2__,"An Exception occuered While Updating DLAP ACH Info");
                __seg__.SegmentDone();
                break;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                {
                    ACHResponseType __ACHResponseMsg = new ACHResponseType("ACHResponseMsg", __ctx1__);

                    ApplyTransform(typeof(DLAPACHLogic.MakeACHResponse), new object[] {__ACHResponseMsg.MessagePart}, new object[] {__ctx1__.__RestLoanUpdateResponseMsg.MessagePart});

                    if (__ctx1__.__ACHResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ACHResponseMsg);
                    __ctx1__.__ACHResponseMsg = __ACHResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__ACHResponseMsg);
                }
                __ctx1__.__ACHResponseMsg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ACHResponseMsg);
                    __edata.Messages.Add(__ctx1__.__RestLoanUpdateResponseMsg);
                    Tracker.FireEvent(__eventLocations[31],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestLoanUpdateResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestLoanUpdateResponseMsg);
                    __ctx1__.__RestLoanUpdateResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                __ctx1__.__SalesForceObjectId = (System.String)__ctx1__.__ACHRequestMsg.MessagePart.GetDistinguishedField("LoanName");
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                __ctx1__.__SalesForceObjectName = "Loan__c";
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                __ctx1__.__Stage = "ACH Received";
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                __ctx1__.__Status = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ACHResponseMsg.MessagePart, "string(/*[local-name()='ACHResponse' and namespace-uri()='http://SBA.gov/DLAPACH/ACHResponse']/*[local-name()='ACK' and namespace-uri()=''])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                __ctx1__.__LoanName = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ACHRequestMsg.MessagePart, "string(/*[local-name()='ACHRequest' and namespace-uri()='http://SBA.gov/DLAPACH/ACHRequestRequest']/*[local-name()='LoanName' and namespace-uri()=''])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 56;
            case 56:
                __ctx1__.__RestLoanUpdateException = new System.Exception("DLAP ACH Loan Query Rest Exception  -  " + "Loan Name not found in the Salesfroce");
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                throw __ctx1__.__RestLoanUpdateException;
            case 61:
                if ( !PreProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 62;
            case 62:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 64;
            case 64:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope36_2 __ctx2__ = (____scope36_2)_stateMgrs[2];
            __ProcessLogic_root_0 __ctx0__ = (__ProcessLogic_root_0)_stateMgrs[0];
            __ProcessLogic_1 __ctx1__ = (__ProcessLogic_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __condition__ = __ctx2__.__AEx_0.InnerException != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 8;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__MessageTemp = __ctx2__.__AEx_0.InnerException.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__Message = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                System.Diagnostics.EventLog.WriteEntry("DLAP ACH Exception", __ctx1__.__Message);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 8:
                __ctx1__.__MessageTemp = __ctx2__.__AEx_0.Message.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__Message = __ctx1__.__MessageTemp.Substring(0, System.Convert.ToInt32(System.Math.Min(900U, __ctx1__.__MessageTemp.Length))) + "Total String Length:" + __ctx1__.__MessageTemp.Length.ToString();
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                System.Diagnostics.EventLog.WriteEntry("DLAP ACH Exception", __ctx1__.__Message);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__AEx_0 = null;
                Tracker.FireEvent(__eventLocations[42],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__LoanName = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__ACHRequestMsg.MessagePart, "string(/*[local-name()='ACHRequest' and namespace-uri()='http://SBA.gov/DLAPACH/ACHRequestRequest']/*[local-name()='LoanName' and namespace-uri()=''])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __condition__ = !System.String.IsNullOrEmpty(__ctx1__.__ApplicationNumber);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 17;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__ApplicationNumber = __ctx1__.__ApplicationNumber;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 17:
                __ctx1__.__ApplicationNumber = "NoAppNumber";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx1__.__SalesForceObjectId = (System.String)__ctx1__.__ACHRequestMsg.MessagePart.GetDistinguishedField("LoanName");
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__SalesForceObjectName = "Loan";
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.__Stage = "ACH Received";
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__Status = "Error";
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.__OrchestrationInstanceId = Microsoft.XLANGs.Core.Service.RootService.InstanceId;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    ACHFaultResponseType __ACHFaultResponseMsg = new ACHFaultResponseType("ACHFaultResponseMsg", __ctx1__);

                    __ctx1__.__TempFaultResponse.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__TempFaultResponse.UnderlyingXmlDocument.LoadXml(System.String.Format(@"<ns0:Fault xmlns:ns0='http://SBA.gov/DLAPACH/ACHFault'><FaultString>Exception:DLAP ACH</FaultString><FaultCode>{0}</FaultCode></ns0:Fault>", System.Security.SecurityElement.Escape(__ctx1__.__Message)));
                    __ACHFaultResponseMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempFaultResponse.UnderlyingXmlDocument);

                    if (__ctx1__.__ACHFaultResponseMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ACHFaultResponseMsg);
                    __ctx1__.__ACHFaultResponseMsg = __ACHFaultResponseMsg;
                    __ctx1__.RefMessage(__ctx1__.__ACHFaultResponseMsg);
                }
                __ctx1__.__ACHFaultResponseMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ACHFaultResponseMsg);
                    Tracker.FireEvent(__eventLocations[44],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ACHPort.SendFault(0, 0, __ctx1__.__ACHFaultResponseMsg, null, null, __ctx2__, __seg__);
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ACHFaultResponseMsg);
                    __edata.PortName = @"ACHPort";
                    Tracker.FireEvent(__eventLocations[46],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ACHFaultResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ACHFaultResponseMsg);
                    __ctx1__.__ACHFaultResponseMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                {
                    Microsoft.XLANGs.Core.Service svc = new DLAPACH.EventRequest(3, InstanceId, this);
                    _stateMgrs[3] = svc;
                    __ctx2__.StartCall(__seg__, svc, __eventLocations[47],new object[] {__ctx1__.__ApplicationNumber, __ctx1__.__SalesForceObjectId, __ctx1__.__Message, __ctx1__.__SalesForceObjectName, __ctx1__.__Stage, __ctx1__.__Status, __ctx1__.__Empty, __ctx1__.__OrchestrationInstanceId});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[3]).Args;
                }
                Tracker.FireEvent(__eventLocations[48],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[49],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                RequestTerminate(__ctx2__,"An error occurred while processing the DLAP ACH");
                __seg__.SegmentDone();
                break;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{928FCAE9-BCD4-4A7C-A8C3-C2A2C71665D1}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{DFD7F377-5663-437C-97DB-1840FECB76FF}"))
        };

    }
    //#line 298 "C:\Users\Apudota\Documents\GitAzureRepo\DLAP ACH\DLAP ACH Logic\ACHEventRequest.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DLAPACH.RestEventPortType)
        },
        new System.String[] {
            "RestEventPort"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class EventRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Application_Number__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String SObject_ID__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Log_Message__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String SObject_Name__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Stage__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Status__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String Auto_Decline_Reason__c,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Guid OrchestrationInstanceId)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(EventRequest));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static EventRequest()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __EventRequest_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public EventRequest(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "EventRequest", tracker)
        {
            ConstructorHelper();
        }

        public EventRequest(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "EventRequest")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>2ee6dff8-07f1-4535-87b4-ca35f04552ce</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>a676f29c-3ad3-441a-9f17-93e93bcf3594</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Application_Number__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>2cc70f21-fb1e-44c1-aa0a-270226a1cb6b</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SObject_ID__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>abf6e77a-f970-4150-8b96-a18764dee685</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Log_Message__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>9c3da375-0e18-4100-93a5-95e54e96444f</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>SObject_Name__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>5ea50e81-ba95-40b0-b919-e29bb55068a1</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Stage__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>6037bce8-4a3d-4cbd-981d-a85a9a4bd78c</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Status__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>180e5926-6764-420e-bc34-850c915c92de</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>Auto_Decline_Reason__c</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>8f5afe28-20b3-40a6-be0e-e3c5f9e35113</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>OrchestrationInstanceId</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>f84d8b89-0605-4efc-a0fa-b6bca8404099</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct Rest Event Request Msg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7c03b257-1f9d-4a02-b591-aea5f1667fe7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Make Request Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e7aaa676-ad3b-4b9b-a092-1ae10c02d9bb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6d47e91d-bd62-40ed-9a49-af24cec37cc9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send Rest Event Request</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>6e81659d-4305-431e-a67a-e169f0f4aabe</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Rest Event Response</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9158f587-ec12-486b-bd82-6c1bcab8b47e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Extract Values</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>6b1d035d-d610-4c90-af71-267a9a0a5129</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Valid Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>7d48d2d0-06a2-4413-a260-052a231c2896</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Error</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>39f3c870-1aa8-4c00-950b-0e1611a58029</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>62204449-a1eb-4fc8-b1bf-0121af48e99d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Rest Error </shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>103f3149-950d-40b4-aad1-5c4f7df5fc69</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'EventRequest'</ActionName><IsAtomic>0</IsAtomic><Line>298</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>317</Line><Position>13</Position><ShapeID>'f84d8b89-0605-4efc-a0fa-b6bca8404099'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventRequestMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestEventRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>344</Line><Position>13</Position><ShapeID>'6d47e91d-bd62-40ed-9a49-af24cec37cc9'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventRequestMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestEventRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>346</Line><Position>13</Position><ShapeID>'6e81659d-4305-431e-a67a-e169f0f4aabe'</ShapeID>
<Messages>
	<MsgInfo><name>RestEventResponseMsg</name><part>MessagePart</part><schema>DLAPACHSalesforceDefinition.RestEventResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>348</Line><Position>30</Position><ShapeID>'9158f587-ec12-486b-bd82-6c1bcab8b47e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>352</Line><Position>13</Position><ShapeID>'6b1d035d-d610-4c90-af71-267a9a0a5129'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>355</Line><Position>36</Position><ShapeID>'39f3c870-1aa8-4c00-950b-0e1611a58029'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>357</Line><Position>17</Position><ShapeID>'62204449-a1eb-4fc8-b1bf-0121af48e99d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='bbcbebda-889c-43dd-8d4b-e041fb1ae986' LowerBound='1.1' HigherBound='84.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DLAPACH' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='07b579c5-839a-4e4d-a217-7913da78764d' ParentLink='Module_PortType' LowerBound='12.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestEventPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='36a52f52-fb4b-4e31-a633-efdd4af743a9' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='425e8e1f-f6d6-4ae9-9ee4-9e16e783be00' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.33'>
                    <om:Property Name='Ref' Value='DLAPACH.RestEventRequestType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='d5e4a510-d20b-4445-a7b8-b6dab9dd707d' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='16.35' HigherBound='16.56'>
                    <om:Property Name='Ref' Value='DLAPACH.RestEventResponseType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ef8a0adb-5611-46ed-b4e2-b0d6fdede31d' ParentLink='Module_MessageType' LowerBound='4.1' HigherBound='8.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestEventRequestType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='043cbdb6-b282-4738-81d9-208829dc2e67' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='6.1' HigherBound='7.1'>
                <om:Property Name='ClassName' Value='DLAPACHSalesforceDefinition.RestEventRequest' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='73fe28fb-8f44-4787-a6e3-d0761df92d6e' ParentLink='Module_MessageType' LowerBound='8.1' HigherBound='12.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RestEventResponseType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PartDeclaration' OID='eb73e6ae-3df9-4856-9b63-37e17334d5f3' ParentLink='MultipartMessageType_PartDeclaration' LowerBound='10.1' HigherBound='11.1'>
                <om:Property Name='ClassName' Value='DLAPACHSalesforceDefinition.RestEventResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessagePart' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='337f13cb-d5ce-4a15-be06-bbf4dd36692c' ParentLink='Module_ServiceDeclaration' LowerBound='19.1' HigherBound='83.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='EventRequest' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='8fdeac09-2c4f-4ce7-8adb-ac78e1512acd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TempXml' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a95680b5-d687-4fa0-9f64-730e1fe273ca' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='GUID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='034db045-a866-4f9c-b63e-9dfcdd93bd71' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4cb16eb8-b513-4ffb-863a-7e9fd6b86d9f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventSFID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='655bc5ef-bb88-414d-82b9-8a08a169cfba' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventException' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6e7fe960-d5a3-4467-b7ea-c1cd8a4a3046' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='DLAPACH.RestEventRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventRequestMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ea9f32f2-a444-40e6-a63a-fdc3f7748aec' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='DLAPACH.RestEventResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventResponseMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='2ee6dff8-07f1-4535-87b4-ca35f04552ce' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='a676f29c-3ad3-441a-9f17-93e93bcf3594' ParentLink='ServiceBody_Declaration' LowerBound='31.15' HigherBound='31.50'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Application_Number__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='2cc70f21-fb1e-44c1-aa0a-270226a1cb6b' ParentLink='ServiceBody_Declaration' LowerBound='31.52' HigherBound='31.79'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SObject_ID__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='abf6e77a-f970-4150-8b96-a18764dee685' ParentLink='ServiceBody_Declaration' LowerBound='31.81' HigherBound='31.109'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Log_Message__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='9c3da375-0e18-4100-93a5-95e54e96444f' ParentLink='ServiceBody_Declaration' LowerBound='31.111' HigherBound='31.140'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SObject_Name__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='5ea50e81-ba95-40b0-b919-e29bb55068a1' ParentLink='ServiceBody_Declaration' LowerBound='31.142' HigherBound='31.164'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Stage__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='6037bce8-4a3d-4cbd-981d-a85a9a4bd78c' ParentLink='ServiceBody_Declaration' LowerBound='31.166' HigherBound='31.189'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Status__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='180e5926-6764-420e-bc34-850c915c92de' ParentLink='ServiceBody_Declaration' LowerBound='31.191' HigherBound='31.227'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Auto_Decline_Reason__c' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='8f5afe28-20b3-40a6-be0e-e3c5f9e35113' ParentLink='ServiceBody_Declaration' LowerBound='31.229' HigherBound='31.264'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Guid' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='OrchestrationInstanceId' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='f84d8b89-0605-4efc-a0fa-b6bca8404099' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='65.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct Rest Event Request Msg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='7c03b257-1f9d-4a02-b591-aea5f1667fe7' ParentLink='ComplexStatement_Statement' LowerBound='41.1' HigherBound='64.1'>
                        <om:Property Name='Expression' Value='TempXml = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;Status__c = System.Security.SecurityElement.Escape(Status__c); &#xD;&#xA;&#xD;&#xA;Stage__c = System.Security.SecurityElement.Escape(Stage__c);&#xD;&#xA; &#xD;&#xA;Application_Number__c = System.Security.SecurityElement.Escape(Application_Number__c); &#xD;&#xA;&#xD;&#xA;SObject_Name__c = System.Security.SecurityElement.Escape(SObject_Name__c); &#xD;&#xA;&#xD;&#xA;SObject_ID__c= System.Security.SecurityElement.Escape(SObject_ID__c); &#xD;&#xA;&#xD;&#xA;Log_Message__c = System.Security.SecurityElement.Escape(Log_Message__c); &#xD;&#xA;&#xD;&#xA;GUID = System.DateTime.Now.ToString(&quot;yyyyMMddHHmmssfffffff&quot;)+&quot;--&quot;+System.Convert.ToString(OrchestrationInstanceId);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;TempXml.LoadXml(System.String.Format(&quot;&lt;ns0:SaveRequest xmlns:ns0=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventRequest&apos;&gt;&lt;ns0:allOrNone&gt;true&lt;/ns0:allOrNone&gt;&lt;ns0:records type=&apos;Event_Request__c&apos;&gt;&lt;ns0:Application_Number__c&gt;{0}&lt;/ns0:Application_Number__c&gt;&lt;ns0:SObject_ID__c&gt;{1}&lt;/ns0:SObject_ID__c&gt;&lt;ns0:Log_Message__c&gt;{2}&lt;/ns0:Log_Message__c&gt;&lt;ns0:SObject_Name__c&gt;{3}&lt;/ns0:SObject_Name__c&gt;&lt;ns0:Stage__c&gt;{4}&lt;/ns0:Stage__c&gt;&lt;ns0:Status__c&gt;{5}&lt;/ns0:Status__c&gt;&lt;ns0:Auto_Decline_Reason__c&gt;{6}&lt;/ns0:Auto_Decline_Reason__c&gt;&lt;ns0:GUID__c&gt;{7}&lt;/ns0:GUID__c&gt;&lt;/ns0:records&gt;&lt;/ns0:SaveRequest&gt;&quot;,Application_Number__c,SObject_ID__c,Log_Message__c,SObject_Name__c,Stage__c,Status__c,Auto_Decline_Reason__c,GUID));&#xD;&#xA;&#xD;&#xA;RestEventRequestMsg.MessagePart = TempXml;&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='Make Request Msg' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='e7aaa676-ad3b-4b9b-a092-1ae10c02d9bb' ParentLink='Construct_MessageRef' LowerBound='39.23' HigherBound='39.42'>
                        <om:Property Name='Ref' Value='RestEventRequestMsg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='6d47e91d-bd62-40ed-9a49-af24cec37cc9' ParentLink='ServiceBody_Statement' LowerBound='65.1' HigherBound='67.1'>
                    <om:Property Name='PortName' Value='RestEventPort' />
                    <om:Property Name='MessageName' Value='RestEventRequestMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send Rest Event Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='6e81659d-4305-431e-a67a-e169f0f4aabe' ParentLink='ServiceBody_Statement' LowerBound='67.1' HigherBound='69.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='RestEventPort' />
                    <om:Property Name='MessageName' Value='RestEventResponseMsg' />
                    <om:Property Name='OperationName' Value='Operation' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Rest Event Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='9158f587-ec12-486b-bd82-6c1bcab8b47e' ParentLink='ServiceBody_Statement' LowerBound='69.1' HigherBound='73.1'>
                    <om:Property Name='Expression' Value='RestEventMessage =  xpath(RestEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;]/*[local-name()=&apos;errors&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;]/*[local-name()=&apos;message&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;RestEventSFID = xpath(RestEventResponseMsg.MessagePart,&quot;string(/*[local-name()=&apos;results&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;]/*[local-name()=&apos;id&apos; and namespace-uri()=&apos;http://SBA.gov/DLAPACH/REST/INSERT/EventResponse&apos;])&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Extract Values' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='6b1d035d-d610-4c90-af71-267a9a0a5129' ParentLink='ServiceBody_Statement' LowerBound='73.1' HigherBound='81.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Valid Response' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='7d48d2d0-06a2-4413-a260-052a231c2896' ParentLink='ReallyComplexStatement_Branch' LowerBound='74.13' HigherBound='81.1'>
                        <om:Property Name='Expression' Value='!System.String.IsNullOrWhiteSpace(RestEventMessage) &amp;&amp; (RestEventSFID.Length == 0)' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Error' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='39f3c870-1aa8-4c00-950b-0e1611a58029' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='78.1'>
                            <om:Property Name='Expression' Value='RestEventException = new System.Exception(&quot;DLAP ACH Evenet Request Rest Exception  -  &quot; + RestEventMessage);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rest Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Throw' OID='62204449-a1eb-4fc8-b1bf-0121af48e99d' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='80.1'>
                            <om:Property Name='ThrownReference' Value='RestEventException' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rest Error ' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='103f3149-950d-40b4-aad1-5c4f7df5fc69' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e730237c-d203-49ea-aabb-c5922f587297' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='24.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DLAPACH.RestEventPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RestEventPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='cb8f9576-30e9-40b2-8d5e-878631c8bbfd' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __EventRequest_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __EventRequest_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EventRequest")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                EventRequest __svc__ = (EventRequest)_service;
                __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RestEventPort != null)
                {
                    __svc__.RestEventPort.Close(this, null);
                    __svc__.RestEventPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __EventRequest_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __EventRequest_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "EventRequest")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                EventRequest __svc__ = (EventRequest)_service;
                __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)(__svc__._stateMgrs[0]);
                __EventRequest_1 __ctx1__ = (__EventRequest_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__Log_Message__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__TempXml = null;
                if (__ctx1__ != null)
                    __ctx1__.__Stage__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__GUID = null;
                if (__ctx1__ != null && __ctx1__.__RestEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                    __ctx1__.__RestEventResponseMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SObject_ID__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Application_Number__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__SObject_Name__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventException = null;
                if (__ctx1__ != null && __ctx1__.__RestEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__Status__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__Auto_Decline_Reason__c = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventSFID = null;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventRequestMsg")]
            internal RestEventRequestType __RestEventRequestMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventResponseMsg")]
            internal RestEventResponseType __RestEventResponseMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TempXml")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __TempXml;
            [Microsoft.XLANGs.Core.UserVariableAttribute("GUID")]
            internal System.String __GUID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventMessage")]
            internal System.String __RestEventMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventSFID")]
            internal System.String __RestEventSFID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventException")]
            internal System.Exception __RestEventException;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Application_Number__c")]
            internal System.String __Application_Number__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SObject_ID__c")]
            internal System.String __SObject_ID__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Log_Message__c")]
            internal System.String __Log_Message__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SObject_Name__c")]
            internal System.String __SObject_Name__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Stage__c")]
            internal System.String __Stage__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Status__c")]
            internal System.String __Status__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Auto_Decline_Reason__c")]
            internal System.String __Auto_Decline_Reason__c;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrchestrationInstanceId")]
            internal System.Guid __OrchestrationInstanceId;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("RestEventPort")]
        internal RestEventPortType RestEventPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RestEventPortType.Operation},
                                               typeof(EventRequest).GetField("RestEventPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(EventRequest), "RestEventPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "f84d8b89-0605-4efc-a0fa-b6bca8404099", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "f84d8b89-0605-4efc-a0fa-b6bca8404099", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6d47e91d-bd62-40ed-9a49-af24cec37cc9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "6d47e91d-bd62-40ed-9a49-af24cec37cc9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "6e81659d-4305-431e-a67a-e169f0f4aabe", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "6e81659d-4305-431e-a67a-e169f0f4aabe", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9158f587-ec12-486b-bd82-6c1bcab8b47e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9158f587-ec12-486b-bd82-6c1bcab8b47e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "6b1d035d-d610-4c90-af71-267a9a0a5129", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "39f3c870-1aa8-4c00-950b-0e1611a58029", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "39f3c870-1aa8-4c00-950b-0e1611a58029", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "62204449-a1eb-4fc8-b1bf-0121af48e99d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "6b1d035d-d610-4c90-af71-267a9a0a5129", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,2,2,3,4,4,4,5,6,6,7,8,8,9,9,10,10,11,11,12,13,13,14,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)_stateMgrs[0];
            __EventRequest_1 __ctx1__ = (__EventRequest_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RestEventPort = new RestEventPortType(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __EventRequest_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __EventRequest_root_0 __ctx0__ = (__EventRequest_root_0)_stateMgrs[0];
            __EventRequest_1 __ctx1__ = (__EventRequest_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Application_Number__c = (System.String)Args[0];
                __ctx1__.__SObject_ID__c = (System.String)Args[1];
                __ctx1__.__Log_Message__c = (System.String)Args[2];
                __ctx1__.__SObject_Name__c = (System.String)Args[3];
                __ctx1__.__Stage__c = (System.String)Args[4];
                __ctx1__.__Status__c = (System.String)Args[5];
                __ctx1__.__Auto_Decline_Reason__c = (System.String)Args[6];
                __ctx1__.__OrchestrationInstanceId = (System.Guid)Args[7];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__TempXml = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__GUID = default(System.String);
                __ctx1__.__RestEventMessage = default(System.String);
                __ctx1__.__RestEventSFID = default(System.String);
                __ctx1__.__RestEventException = default(System.Exception);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__TempXml.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__GUID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__RestEventMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__RestEventSFID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__RestEventException = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    RestEventRequestType __RestEventRequestMsg = new RestEventRequestType("RestEventRequestMsg", __ctx1__);

                    __ctx1__.__TempXml.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__Status__c = System.Security.SecurityElement.Escape(__ctx1__.__Status__c);
                    __ctx1__.__Stage__c = System.Security.SecurityElement.Escape(__ctx1__.__Stage__c);
                    __ctx1__.__Application_Number__c = System.Security.SecurityElement.Escape(__ctx1__.__Application_Number__c);
                    __ctx1__.__SObject_Name__c = System.Security.SecurityElement.Escape(__ctx1__.__SObject_Name__c);
                    __ctx1__.__SObject_ID__c = System.Security.SecurityElement.Escape(__ctx1__.__SObject_ID__c);
                    __ctx1__.__Log_Message__c = System.Security.SecurityElement.Escape(__ctx1__.__Log_Message__c);
                    __ctx1__.__GUID = System.DateTime.Now.ToString("yyyyMMddHHmmssfffffff") + "--" + System.Convert.ToString(__ctx1__.__OrchestrationInstanceId);
                    __ctx1__.__TempXml.UnderlyingXmlDocument.LoadXml(System.String.Format("<ns0:SaveRequest xmlns:ns0='http://SBA.gov/DLAPACH/REST/INSERT/EventRequest'><ns0:allOrNone>true</ns0:allOrNone><ns0:records type='Event_Request__c'><ns0:Application_Number__c>{0}</ns0:Application_Number__c><ns0:SObject_ID__c>{1}</ns0:SObject_ID__c><ns0:Log_Message__c>{2}</ns0:Log_Message__c><ns0:SObject_Name__c>{3}</ns0:SObject_Name__c><ns0:Stage__c>{4}</ns0:Stage__c><ns0:Status__c>{5}</ns0:Status__c><ns0:Auto_Decline_Reason__c>{6}</ns0:Auto_Decline_Reason__c><ns0:GUID__c>{7}</ns0:GUID__c></ns0:records></ns0:SaveRequest>", __ctx1__.__Application_Number__c, __ctx1__.__SObject_ID__c, __ctx1__.__Log_Message__c, __ctx1__.__SObject_Name__c, __ctx1__.__Stage__c, __ctx1__.__Status__c, __ctx1__.__Auto_Decline_Reason__c, __ctx1__.__GUID));
                    if (__ctx1__ != null)
                        __ctx1__.__Auto_Decline_Reason__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Status__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Stage__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__SObject_Name__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Log_Message__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__SObject_ID__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__Application_Number__c = null;
                    if (__ctx1__ != null)
                        __ctx1__.__GUID = null;
                    __RestEventRequestMsg.MessagePart.LoadFrom((System.Xml.XmlDocument)__ctx1__.__TempXml.UnderlyingXmlDocument);
                    if (__ctx1__ != null)
                        __ctx1__.__TempXml = null;

                    if (__ctx1__.__RestEventRequestMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = __RestEventRequestMsg;
                    __ctx1__.RefMessage(__ctx1__.__RestEventRequestMsg);
                }
                __ctx1__.__RestEventRequestMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RestEventRequestMsg);
                    Tracker.FireEvent(__eventLocations[3],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RestEventPort.SendMessage(0, __ctx1__.__RestEventRequestMsg, null, null, out __ctx0__.__subWrapper0, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RestEventRequestMsg);
                    __edata.PortName = @"RestEventPort";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__RestEventRequestMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventRequestMsg);
                    __ctx1__.__RestEventRequestMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!RestEventPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper0 != null)
                {
                    __ctx0__.__subWrapper0.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper0 = null;
                }
                if (__ctx1__.__RestEventResponseMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                __ctx1__.__RestEventResponseMsg = new RestEventResponseType("RestEventResponseMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__RestEventResponseMsg);
                RestEventPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__RestEventResponseMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RestEventPort != null)
                {
                    RestEventPort.Close(__ctx1__, __seg__);
                    RestEventPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__RestEventResponseMsg);
                    __edata.PortName = @"RestEventPort";
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx1__.__RestEventMessage = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse']/*[local-name()='errors' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse']/*[local-name()='message' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse'])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                __ctx1__.__RestEventSFID = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__RestEventResponseMsg.MessagePart, "string(/*[local-name()='results' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse']/*[local-name()='result' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse']/*[local-name()='id' and namespace-uri()='http://SBA.gov/DLAPACH/REST/INSERT/EventResponse'])", typeof(System.String));
                if (__ctx1__ != null && __ctx1__.__RestEventResponseMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RestEventResponseMsg);
                    __ctx1__.__RestEventResponseMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __condition__ = !System.String.IsNullOrWhiteSpace(__ctx1__.__RestEventMessage) && (__ctx1__.__RestEventSFID.Length == 0);
                if (__ctx1__ != null)
                    __ctx1__.__RestEventSFID = null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 29;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                __ctx1__.__RestEventException = new System.Exception("DLAP ACH Evenet Request Rest Exception  -  " + __ctx1__.__RestEventMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                throw __ctx1__.__RestEventException;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventException = null;
                if (__ctx1__ != null)
                    __ctx1__.__RestEventMessage = null;
                Tracker.FireEvent(__eventLocations[14],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 33;
            case 33:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{DDC86BFF-10E3-415A-BAA2-9C7FC23CC373}"))
        };

    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
