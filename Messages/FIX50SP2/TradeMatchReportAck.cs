// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class TradeMatchReportAck : Message
        {
            public const string MsgType = "DD";

            public TradeMatchReportAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("DD"));
            }

            public TradeMatchReportAck(
                    QuickFix.Fields.TrdMatchID aTrdMatchID,
                    QuickFix.Fields.TradeMatchAckStatus aTradeMatchAckStatus
                ) : this()
            {
                this.TrdMatchID = aTrdMatchID;
                this.TradeMatchAckStatus = aTradeMatchAckStatus;
            }

            public QuickFix.Fields.ApplID ApplID
            {
                get
                {
                    QuickFix.Fields.ApplID val = new QuickFix.Fields.ApplID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplID val)
            {
                this.ApplID = val;
            }

            public QuickFix.Fields.ApplID Get(QuickFix.Fields.ApplID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplID val)
            {
                return IsSetApplID();
            }

            public bool IsSetApplID()
            {
                return IsSetField(Tags.ApplID);
            }
            public QuickFix.Fields.ApplSeqNum ApplSeqNum
            {
                get
                {
                    QuickFix.Fields.ApplSeqNum val = new QuickFix.Fields.ApplSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplSeqNum val)
            {
                this.ApplSeqNum = val;
            }

            public QuickFix.Fields.ApplSeqNum Get(QuickFix.Fields.ApplSeqNum val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplSeqNum val)
            {
                return IsSetApplSeqNum();
            }

            public bool IsSetApplSeqNum()
            {
                return IsSetField(Tags.ApplSeqNum);
            }
            public QuickFix.Fields.ApplLastSeqNum ApplLastSeqNum
            {
                get
                {
                    QuickFix.Fields.ApplLastSeqNum val = new QuickFix.Fields.ApplLastSeqNum();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplLastSeqNum val)
            {
                this.ApplLastSeqNum = val;
            }

            public QuickFix.Fields.ApplLastSeqNum Get(QuickFix.Fields.ApplLastSeqNum val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplLastSeqNum val)
            {
                return IsSetApplLastSeqNum();
            }

            public bool IsSetApplLastSeqNum()
            {
                return IsSetField(Tags.ApplLastSeqNum);
            }
            public QuickFix.Fields.ApplResendFlag ApplResendFlag
            {
                get
                {
                    QuickFix.Fields.ApplResendFlag val = new QuickFix.Fields.ApplResendFlag();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplResendFlag val)
            {
                this.ApplResendFlag = val;
            }

            public QuickFix.Fields.ApplResendFlag Get(QuickFix.Fields.ApplResendFlag val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplResendFlag val)
            {
                return IsSetApplResendFlag();
            }

            public bool IsSetApplResendFlag()
            {
                return IsSetField(Tags.ApplResendFlag);
            }
            public QuickFix.Fields.TrdMatchID TrdMatchID
            {
                get
                {
                    QuickFix.Fields.TrdMatchID val = new QuickFix.Fields.TrdMatchID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TrdMatchID val)
            {
                this.TrdMatchID = val;
            }

            public QuickFix.Fields.TrdMatchID Get(QuickFix.Fields.TrdMatchID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TrdMatchID val)
            {
                return IsSetTrdMatchID();
            }

            public bool IsSetTrdMatchID()
            {
                return IsSetField(Tags.TrdMatchID);
            }
            public QuickFix.Fields.TradeMatchAckStatus TradeMatchAckStatus
            {
                get
                {
                    QuickFix.Fields.TradeMatchAckStatus val = new QuickFix.Fields.TradeMatchAckStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeMatchAckStatus val)
            {
                this.TradeMatchAckStatus = val;
            }

            public QuickFix.Fields.TradeMatchAckStatus Get(QuickFix.Fields.TradeMatchAckStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeMatchAckStatus val)
            {
                return IsSetTradeMatchAckStatus();
            }

            public bool IsSetTradeMatchAckStatus()
            {
                return IsSetField(Tags.TradeMatchAckStatus);
            }
            public QuickFix.Fields.TradeMatchRejectReason TradeMatchRejectReason
            {
                get
                {
                    QuickFix.Fields.TradeMatchRejectReason val = new QuickFix.Fields.TradeMatchRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeMatchRejectReason val)
            {
                this.TradeMatchRejectReason = val;
            }

            public QuickFix.Fields.TradeMatchRejectReason Get(QuickFix.Fields.TradeMatchRejectReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeMatchRejectReason val)
            {
                return IsSetTradeMatchRejectReason();
            }

            public bool IsSetTradeMatchRejectReason()
            {
                return IsSetField(Tags.TradeMatchRejectReason);
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
            public QuickFix.Fields.Text Text
            {
                get
                {
                    QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Text val)
            {
                this.Text = val;
            }

            public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Text val)
            {
                return IsSetText();
            }

            public bool IsSetText()
            {
                return IsSetField(Tags.Text);
            }
            public QuickFix.Fields.EncodedTextLen EncodedTextLen
            {
                get
                {
                    QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedTextLen val)
            {
                this.EncodedTextLen = val;
            }

            public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedTextLen val)
            {
                return IsSetEncodedTextLen();
            }

            public bool IsSetEncodedTextLen()
            {
                return IsSetField(Tags.EncodedTextLen);
            }
            public QuickFix.Fields.EncodedText EncodedText
            {
                get
                {
                    QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedText val)
            {
                this.EncodedText = val;
            }

            public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedText val)
            {
                return IsSetEncodedText();
            }

            public bool IsSetEncodedText()
            {
                return IsSetField(Tags.EncodedText);
            }
        }
    }
}
