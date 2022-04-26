// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class QuoteAck : Message
        {
            public const string MsgType = "CW";

            public QuoteAck() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CW"));
            }

            public QuoteAck(
                    QuickFix.Fields.QuoteAckStatus aQuoteAckStatus
                ) : this()
            {
                this.QuoteAckStatus = aQuoteAckStatus;
            }

            public QuickFix.Fields.QuoteID QuoteID
            {
                get
                {
                    QuickFix.Fields.QuoteID val = new QuickFix.Fields.QuoteID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteID val)
            {
                this.QuoteID = val;
            }

            public QuickFix.Fields.QuoteID Get(QuickFix.Fields.QuoteID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteID val)
            {
                return IsSetQuoteID();
            }

            public bool IsSetQuoteID()
            {
                return IsSetField(Tags.QuoteID);
            }
            public QuickFix.Fields.QuoteMsgID QuoteMsgID
            {
                get
                {
                    QuickFix.Fields.QuoteMsgID val = new QuickFix.Fields.QuoteMsgID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteMsgID val)
            {
                this.QuoteMsgID = val;
            }

            public QuickFix.Fields.QuoteMsgID Get(QuickFix.Fields.QuoteMsgID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteMsgID val)
            {
                return IsSetQuoteMsgID();
            }

            public bool IsSetQuoteMsgID()
            {
                return IsSetField(Tags.QuoteMsgID);
            }
            public QuickFix.Fields.QuoteReqID QuoteReqID
            {
                get
                {
                    QuickFix.Fields.QuoteReqID val = new QuickFix.Fields.QuoteReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteReqID val)
            {
                this.QuoteReqID = val;
            }

            public QuickFix.Fields.QuoteReqID Get(QuickFix.Fields.QuoteReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteReqID val)
            {
                return IsSetQuoteReqID();
            }

            public bool IsSetQuoteReqID()
            {
                return IsSetField(Tags.QuoteReqID);
            }
            public QuickFix.Fields.QuoteType QuoteType
            {
                get
                {
                    QuickFix.Fields.QuoteType val = new QuickFix.Fields.QuoteType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteType val)
            {
                this.QuoteType = val;
            }

            public QuickFix.Fields.QuoteType Get(QuickFix.Fields.QuoteType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteType val)
            {
                return IsSetQuoteType();
            }

            public bool IsSetQuoteType()
            {
                return IsSetField(Tags.QuoteType);
            }
            public QuickFix.Fields.QuoteCancelType QuoteCancelType
            {
                get
                {
                    QuickFix.Fields.QuoteCancelType val = new QuickFix.Fields.QuoteCancelType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteCancelType val)
            {
                this.QuoteCancelType = val;
            }

            public QuickFix.Fields.QuoteCancelType Get(QuickFix.Fields.QuoteCancelType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteCancelType val)
            {
                return IsSetQuoteCancelType();
            }

            public bool IsSetQuoteCancelType()
            {
                return IsSetField(Tags.QuoteCancelType);
            }
            public QuickFix.Fields.SecondaryQuoteID SecondaryQuoteID
            {
                get
                {
                    QuickFix.Fields.SecondaryQuoteID val = new QuickFix.Fields.SecondaryQuoteID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecondaryQuoteID val)
            {
                this.SecondaryQuoteID = val;
            }

            public QuickFix.Fields.SecondaryQuoteID Get(QuickFix.Fields.SecondaryQuoteID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecondaryQuoteID val)
            {
                return IsSetSecondaryQuoteID();
            }

            public bool IsSetSecondaryQuoteID()
            {
                return IsSetField(Tags.SecondaryQuoteID);
            }
            public QuickFix.Fields.QuoteAckStatus QuoteAckStatus
            {
                get
                {
                    QuickFix.Fields.QuoteAckStatus val = new QuickFix.Fields.QuoteAckStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteAckStatus val)
            {
                this.QuoteAckStatus = val;
            }

            public QuickFix.Fields.QuoteAckStatus Get(QuickFix.Fields.QuoteAckStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteAckStatus val)
            {
                return IsSetQuoteAckStatus();
            }

            public bool IsSetQuoteAckStatus()
            {
                return IsSetField(Tags.QuoteAckStatus);
            }
            public QuickFix.Fields.QuoteRejectReason QuoteRejectReason
            {
                get
                {
                    QuickFix.Fields.QuoteRejectReason val = new QuickFix.Fields.QuoteRejectReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.QuoteRejectReason val)
            {
                this.QuoteRejectReason = val;
            }

            public QuickFix.Fields.QuoteRejectReason Get(QuickFix.Fields.QuoteRejectReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.QuoteRejectReason val)
            {
                return IsSetQuoteRejectReason();
            }

            public bool IsSetQuoteRejectReason()
            {
                return IsSetField(Tags.QuoteRejectReason);
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
            public QuickFix.Fields.NoPartyIDs NoPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoPartyIDs val = new QuickFix.Fields.NoPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoPartyIDs val)
            {
                this.NoPartyIDs = val;
            }

            public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoPartyIDs val)
            {
                return IsSetNoPartyIDs();
            }

            public bool IsSetNoPartyIDs()
            {
                return IsSetField(Tags.NoPartyIDs);
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
            public QuickFix.Fields.NoQuoteAttributes NoQuoteAttributes
            {
                get
                {
                    QuickFix.Fields.NoQuoteAttributes val = new QuickFix.Fields.NoQuoteAttributes();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoQuoteAttributes val)
            {
                this.NoQuoteAttributes = val;
            }

            public QuickFix.Fields.NoQuoteAttributes Get(QuickFix.Fields.NoQuoteAttributes val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoQuoteAttributes val)
            {
                return IsSetNoQuoteAttributes();
            }

            public bool IsSetNoQuoteAttributes()
            {
                return IsSetField(Tags.NoQuoteAttributes);
            }
            public class NoPartyIDsGroup : Group
            {
                public static int[] fieldOrder = { Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, Tags.PartyRoleQualifier, 0 };

                public NoPartyIDsGroup()
                  : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.PartyID PartyID
                {
                    get
                    {
                        QuickFix.Fields.PartyID val = new QuickFix.Fields.PartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyID val)
                {
                    this.PartyID = val;
                }

                public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyID val)
                {
                    return IsSetPartyID();
                }

                public bool IsSetPartyID()
                {
                    return IsSetField(Tags.PartyID);
                }
                public QuickFix.Fields.PartyIDSource PartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.PartyIDSource val = new QuickFix.Fields.PartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyIDSource val)
                {
                    this.PartyIDSource = val;
                }

                public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyIDSource val)
                {
                    return IsSetPartyIDSource();
                }

                public bool IsSetPartyIDSource()
                {
                    return IsSetField(Tags.PartyIDSource);
                }
                public QuickFix.Fields.PartyRole PartyRole
                {
                    get
                    {
                        QuickFix.Fields.PartyRole val = new QuickFix.Fields.PartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRole val)
                {
                    this.PartyRole = val;
                }

                public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRole val)
                {
                    return IsSetPartyRole();
                }

                public bool IsSetPartyRole()
                {
                    return IsSetField(Tags.PartyRole);
                }
                public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoPartySubIDs val = new QuickFix.Fields.NoPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoPartySubIDs val)
                {
                    this.NoPartySubIDs = val;
                }

                public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoPartySubIDs val)
                {
                    return IsSetNoPartySubIDs();
                }

                public bool IsSetNoPartySubIDs()
                {
                    return IsSetField(Tags.NoPartySubIDs);
                }
                public QuickFix.Fields.PartyRoleQualifier PartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.PartyRoleQualifier val = new QuickFix.Fields.PartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PartyRoleQualifier val)
                {
                    this.PartyRoleQualifier = val;
                }

                public QuickFix.Fields.PartyRoleQualifier Get(QuickFix.Fields.PartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PartyRoleQualifier val)
                {
                    return IsSetPartyRoleQualifier();
                }

                public bool IsSetPartyRoleQualifier()
                {
                    return IsSetField(Tags.PartyRoleQualifier);
                }
                public class NoPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.PartySubID, Tags.PartySubIDType, 0 };

                    public NoPartySubIDsGroup()
                      : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.PartySubID PartySubID
                    {
                        get
                        {
                            QuickFix.Fields.PartySubID val = new QuickFix.Fields.PartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubID val)
                    {
                        this.PartySubID = val;
                    }

                    public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubID val)
                    {
                        return IsSetPartySubID();
                    }

                    public bool IsSetPartySubID()
                    {
                        return IsSetField(Tags.PartySubID);
                    }
                    public QuickFix.Fields.PartySubIDType PartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.PartySubIDType val = new QuickFix.Fields.PartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartySubIDType val)
                    {
                        this.PartySubIDType = val;
                    }

                    public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartySubIDType val)
                    {
                        return IsSetPartySubIDType();
                    }

                    public bool IsSetPartySubIDType()
                    {
                        return IsSetField(Tags.PartySubIDType);
                    }

                }
            }
            public class NoQuoteAttributesGroup : Group
            {
                public static int[] fieldOrder = { Tags.QuoteAttributeType, Tags.QuoteAttributeValue, 0 };

                public NoQuoteAttributesGroup()
                  : base(Tags.NoQuoteAttributes, Tags.QuoteAttributeType, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoQuoteAttributesGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.QuoteAttributeType QuoteAttributeType
                {
                    get
                    {
                        QuickFix.Fields.QuoteAttributeType val = new QuickFix.Fields.QuoteAttributeType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.QuoteAttributeType val)
                {
                    this.QuoteAttributeType = val;
                }

                public QuickFix.Fields.QuoteAttributeType Get(QuickFix.Fields.QuoteAttributeType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.QuoteAttributeType val)
                {
                    return IsSetQuoteAttributeType();
                }

                public bool IsSetQuoteAttributeType()
                {
                    return IsSetField(Tags.QuoteAttributeType);
                }
                public QuickFix.Fields.QuoteAttributeValue QuoteAttributeValue
                {
                    get
                    {
                        QuickFix.Fields.QuoteAttributeValue val = new QuickFix.Fields.QuoteAttributeValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.QuoteAttributeValue val)
                {
                    this.QuoteAttributeValue = val;
                }

                public QuickFix.Fields.QuoteAttributeValue Get(QuickFix.Fields.QuoteAttributeValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.QuoteAttributeValue val)
                {
                    return IsSetQuoteAttributeValue();
                }

                public bool IsSetQuoteAttributeValue()
                {
                    return IsSetField(Tags.QuoteAttributeValue);
                }

            }
        }
    }
}
