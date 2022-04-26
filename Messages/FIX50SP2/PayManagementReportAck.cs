// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PayManagementReportAck : Message
        {
            public const string MsgType = "EB";

            public PayManagementReportAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("EB"));
            }

            public PayManagementReportAck(
                    QuickFix.Fields.PayReportID aPayReportID,
                    QuickFix.Fields.PayReportStatus aPayReportStatus
                ) : this()
            {
                this.PayReportID = aPayReportID;
                this.PayReportStatus = aPayReportStatus;
            }

            public QuickFix.Fields.PayReportID PayReportID
            {
                get
                {
                    QuickFix.Fields.PayReportID val = new QuickFix.Fields.PayReportID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PayReportID val)
            {
                this.PayReportID = val;
            }

            public QuickFix.Fields.PayReportID Get(QuickFix.Fields.PayReportID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PayReportID val)
            {
                return IsSetPayReportID();
            }

            public bool IsSetPayReportID()
            {
                return IsSetField(Tags.PayReportID);
            }
            public QuickFix.Fields.PayReportStatus PayReportStatus
            {
                get
                {
                    QuickFix.Fields.PayReportStatus val = new QuickFix.Fields.PayReportStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PayReportStatus val)
            {
                this.PayReportStatus = val;
            }

            public QuickFix.Fields.PayReportStatus Get(QuickFix.Fields.PayReportStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PayReportStatus val)
            {
                return IsSetPayReportStatus();
            }

            public bool IsSetPayReportStatus()
            {
                return IsSetField(Tags.PayReportStatus);
            }
            public QuickFix.Fields.PayDisputeReason PayDisputeReason
            {
                get
                {
                    QuickFix.Fields.PayDisputeReason val = new QuickFix.Fields.PayDisputeReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PayDisputeReason val)
            {
                this.PayDisputeReason = val;
            }

            public QuickFix.Fields.PayDisputeReason Get(QuickFix.Fields.PayDisputeReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PayDisputeReason val)
            {
                return IsSetPayDisputeReason();
            }

            public bool IsSetPayDisputeReason()
            {
                return IsSetField(Tags.PayDisputeReason);
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
