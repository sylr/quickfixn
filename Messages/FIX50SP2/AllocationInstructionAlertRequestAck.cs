// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class AllocationInstructionAlertRequestAck : Message
        {
            public const string MsgType = "DV";

            public AllocationInstructionAlertRequestAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("DV"));
            }

            public AllocationInstructionAlertRequestAck(
                    QuickFix.Fields.AllocRequestID aAllocRequestID,
                    QuickFix.Fields.AllocRequestStatus aAllocRequestStatus
                ) : this()
            {
                this.AllocRequestID = aAllocRequestID;
                this.AllocRequestStatus = aAllocRequestStatus;
            }

            public QuickFix.Fields.AllocRequestID AllocRequestID
            {
                get
                {
                    QuickFix.Fields.AllocRequestID val = new QuickFix.Fields.AllocRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AllocRequestID val)
            {
                this.AllocRequestID = val;
            }

            public QuickFix.Fields.AllocRequestID Get(QuickFix.Fields.AllocRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AllocRequestID val)
            {
                return IsSetAllocRequestID();
            }

            public bool IsSetAllocRequestID()
            {
                return IsSetField(Tags.AllocRequestID);
            }
            public QuickFix.Fields.AllocRequestStatus AllocRequestStatus
            {
                get
                {
                    QuickFix.Fields.AllocRequestStatus val = new QuickFix.Fields.AllocRequestStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AllocRequestStatus val)
            {
                this.AllocRequestStatus = val;
            }

            public QuickFix.Fields.AllocRequestStatus Get(QuickFix.Fields.AllocRequestStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AllocRequestStatus val)
            {
                return IsSetAllocRequestStatus();
            }

            public bool IsSetAllocRequestStatus()
            {
                return IsSetField(Tags.AllocRequestStatus);
            }
            public QuickFix.Fields.RejectText RejectText
            {
                get
                {
                    QuickFix.Fields.RejectText val = new QuickFix.Fields.RejectText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RejectText val)
            {
                this.RejectText = val;
            }

            public QuickFix.Fields.RejectText Get(QuickFix.Fields.RejectText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RejectText val)
            {
                return IsSetRejectText();
            }

            public bool IsSetRejectText()
            {
                return IsSetField(Tags.RejectText);
            }
            public QuickFix.Fields.EncodedRejectTextLen EncodedRejectTextLen
            {
                get
                {
                    QuickFix.Fields.EncodedRejectTextLen val = new QuickFix.Fields.EncodedRejectTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedRejectTextLen val)
            {
                this.EncodedRejectTextLen = val;
            }

            public QuickFix.Fields.EncodedRejectTextLen Get(QuickFix.Fields.EncodedRejectTextLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedRejectTextLen val)
            {
                return IsSetEncodedRejectTextLen();
            }

            public bool IsSetEncodedRejectTextLen()
            {
                return IsSetField(Tags.EncodedRejectTextLen);
            }
            public QuickFix.Fields.EncodedRejectText EncodedRejectText
            {
                get
                {
                    QuickFix.Fields.EncodedRejectText val = new QuickFix.Fields.EncodedRejectText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedRejectText val)
            {
                this.EncodedRejectText = val;
            }

            public QuickFix.Fields.EncodedRejectText Get(QuickFix.Fields.EncodedRejectText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedRejectText val)
            {
                return IsSetEncodedRejectText();
            }

            public bool IsSetEncodedRejectText()
            {
                return IsSetField(Tags.EncodedRejectText);
            }
        }
    }
}
