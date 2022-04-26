// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PayManagementRequestAck : Message
        {
            public const string MsgType = "DZ";

            public PayManagementRequestAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("DZ"));
            }

            public PayManagementRequestAck(
                    QuickFix.Fields.PayRequestID aPayRequestID,
                    QuickFix.Fields.PayRequestStatus aPayRequestStatus
                ) : this()
            {
                this.PayRequestID = aPayRequestID;
                this.PayRequestStatus = aPayRequestStatus;
            }

            public QuickFix.Fields.PayRequestID PayRequestID
            {
                get
                {
                    QuickFix.Fields.PayRequestID val = new QuickFix.Fields.PayRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PayRequestID val)
            {
                this.PayRequestID = val;
            }

            public QuickFix.Fields.PayRequestID Get(QuickFix.Fields.PayRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PayRequestID val)
            {
                return IsSetPayRequestID();
            }

            public bool IsSetPayRequestID()
            {
                return IsSetField(Tags.PayRequestID);
            }
            public QuickFix.Fields.PayRequestStatus PayRequestStatus
            {
                get
                {
                    QuickFix.Fields.PayRequestStatus val = new QuickFix.Fields.PayRequestStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PayRequestStatus val)
            {
                this.PayRequestStatus = val;
            }

            public QuickFix.Fields.PayRequestStatus Get(QuickFix.Fields.PayRequestStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PayRequestStatus val)
            {
                return IsSetPayRequestStatus();
            }

            public bool IsSetPayRequestStatus()
            {
                return IsSetField(Tags.PayRequestStatus);
            }
        }
    }
}
