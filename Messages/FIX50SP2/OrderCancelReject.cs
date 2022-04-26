// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class OrderCancelReject : Message
        {
            public const string MsgType = "9";

            public OrderCancelReject() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("9"));
            }

            public OrderCancelReject(
                    QuickFix.Fields.OrderID aOrderID,
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.OrdStatus aOrdStatus,
                    QuickFix.Fields.CxlRejResponseTo aCxlRejResponseTo
                ) : this()
            {
                this.OrderID = aOrderID;
                this.ClOrdID = aClOrdID;
                this.OrdStatus = aOrdStatus;
                this.CxlRejResponseTo = aCxlRejResponseTo;
            }

            public QuickFix.Fields.OrderID OrderID
            {
                get
                {
                    QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrderID val)
            {
                this.OrderID = val;
            }

            public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrderID val)
            {
                return IsSetOrderID();
            }

            public bool IsSetOrderID()
            {
                return IsSetField(Tags.OrderID);
            }
            public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
            {
                get
                {
                    QuickFix.Fields.SecondaryOrderID val = new QuickFix.Fields.SecondaryOrderID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecondaryOrderID val)
            {
                this.SecondaryOrderID = val;
            }

            public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecondaryOrderID val)
            {
                return IsSetSecondaryOrderID();
            }

            public bool IsSetSecondaryOrderID()
            {
                return IsSetField(Tags.SecondaryOrderID);
            }
            public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
            {
                get
                {
                    QuickFix.Fields.SecondaryClOrdID val = new QuickFix.Fields.SecondaryClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecondaryClOrdID val)
            {
                this.SecondaryClOrdID = val;
            }

            public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecondaryClOrdID val)
            {
                return IsSetSecondaryClOrdID();
            }

            public bool IsSetSecondaryClOrdID()
            {
                return IsSetField(Tags.SecondaryClOrdID);
            }
            public QuickFix.Fields.ClOrdID ClOrdID
            {
                get
                {
                    QuickFix.Fields.ClOrdID val = new QuickFix.Fields.ClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClOrdID val)
            {
                this.ClOrdID = val;
            }

            public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClOrdID val)
            {
                return IsSetClOrdID();
            }

            public bool IsSetClOrdID()
            {
                return IsSetField(Tags.ClOrdID);
            }
            public QuickFix.Fields.ClOrdLinkID ClOrdLinkID
            {
                get
                {
                    QuickFix.Fields.ClOrdLinkID val = new QuickFix.Fields.ClOrdLinkID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClOrdLinkID val)
            {
                this.ClOrdLinkID = val;
            }

            public QuickFix.Fields.ClOrdLinkID Get(QuickFix.Fields.ClOrdLinkID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClOrdLinkID val)
            {
                return IsSetClOrdLinkID();
            }

            public bool IsSetClOrdLinkID()
            {
                return IsSetField(Tags.ClOrdLinkID);
            }
            public QuickFix.Fields.OrigClOrdID OrigClOrdID
            {
                get
                {
                    QuickFix.Fields.OrigClOrdID val = new QuickFix.Fields.OrigClOrdID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrigClOrdID val)
            {
                this.OrigClOrdID = val;
            }

            public QuickFix.Fields.OrigClOrdID Get(QuickFix.Fields.OrigClOrdID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrigClOrdID val)
            {
                return IsSetOrigClOrdID();
            }

            public bool IsSetOrigClOrdID()
            {
                return IsSetField(Tags.OrigClOrdID);
            }
            public QuickFix.Fields.OrdStatus OrdStatus
            {
                get
                {
                    QuickFix.Fields.OrdStatus val = new QuickFix.Fields.OrdStatus();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrdStatus val)
            {
                this.OrdStatus = val;
            }

            public QuickFix.Fields.OrdStatus Get(QuickFix.Fields.OrdStatus val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrdStatus val)
            {
                return IsSetOrdStatus();
            }

            public bool IsSetOrdStatus()
            {
                return IsSetField(Tags.OrdStatus);
            }
            public QuickFix.Fields.WorkingIndicator WorkingIndicator
            {
                get
                {
                    QuickFix.Fields.WorkingIndicator val = new QuickFix.Fields.WorkingIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.WorkingIndicator val)
            {
                this.WorkingIndicator = val;
            }

            public QuickFix.Fields.WorkingIndicator Get(QuickFix.Fields.WorkingIndicator val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.WorkingIndicator val)
            {
                return IsSetWorkingIndicator();
            }

            public bool IsSetWorkingIndicator()
            {
                return IsSetField(Tags.WorkingIndicator);
            }
            public QuickFix.Fields.OrigOrdModTime OrigOrdModTime
            {
                get
                {
                    QuickFix.Fields.OrigOrdModTime val = new QuickFix.Fields.OrigOrdModTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrigOrdModTime val)
            {
                this.OrigOrdModTime = val;
            }

            public QuickFix.Fields.OrigOrdModTime Get(QuickFix.Fields.OrigOrdModTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrigOrdModTime val)
            {
                return IsSetOrigOrdModTime();
            }

            public bool IsSetOrigOrdModTime()
            {
                return IsSetField(Tags.OrigOrdModTime);
            }
            public QuickFix.Fields.ListID ListID
            {
                get
                {
                    QuickFix.Fields.ListID val = new QuickFix.Fields.ListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ListID val)
            {
                this.ListID = val;
            }

            public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ListID val)
            {
                return IsSetListID();
            }

            public bool IsSetListID()
            {
                return IsSetField(Tags.ListID);
            }
            public QuickFix.Fields.Account Account
            {
                get
                {
                    QuickFix.Fields.Account val = new QuickFix.Fields.Account();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Account val)
            {
                this.Account = val;
            }

            public QuickFix.Fields.Account Get(QuickFix.Fields.Account val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Account val)
            {
                return IsSetAccount();
            }

            public bool IsSetAccount()
            {
                return IsSetField(Tags.Account);
            }
            public QuickFix.Fields.AcctIDSource AcctIDSource
            {
                get
                {
                    QuickFix.Fields.AcctIDSource val = new QuickFix.Fields.AcctIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AcctIDSource val)
            {
                this.AcctIDSource = val;
            }

            public QuickFix.Fields.AcctIDSource Get(QuickFix.Fields.AcctIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AcctIDSource val)
            {
                return IsSetAcctIDSource();
            }

            public bool IsSetAcctIDSource()
            {
                return IsSetField(Tags.AcctIDSource);
            }
            public QuickFix.Fields.AccountType AccountType
            {
                get
                {
                    QuickFix.Fields.AccountType val = new QuickFix.Fields.AccountType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.AccountType val)
            {
                this.AccountType = val;
            }

            public QuickFix.Fields.AccountType Get(QuickFix.Fields.AccountType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.AccountType val)
            {
                return IsSetAccountType();
            }

            public bool IsSetAccountType()
            {
                return IsSetField(Tags.AccountType);
            }
            public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
            {
                get
                {
                    QuickFix.Fields.TradeOriginationDate val = new QuickFix.Fields.TradeOriginationDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeOriginationDate val)
            {
                this.TradeOriginationDate = val;
            }

            public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeOriginationDate val)
            {
                return IsSetTradeOriginationDate();
            }

            public bool IsSetTradeOriginationDate()
            {
                return IsSetField(Tags.TradeOriginationDate);
            }
            public QuickFix.Fields.TradeDate TradeDate
            {
                get
                {
                    QuickFix.Fields.TradeDate val = new QuickFix.Fields.TradeDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradeDate val)
            {
                this.TradeDate = val;
            }

            public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradeDate val)
            {
                return IsSetTradeDate();
            }

            public bool IsSetTradeDate()
            {
                return IsSetField(Tags.TradeDate);
            }
            public QuickFix.Fields.TransactTime TransactTime
            {
                get
                {
                    QuickFix.Fields.TransactTime val = new QuickFix.Fields.TransactTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TransactTime val)
            {
                this.TransactTime = val;
            }

            public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TransactTime val)
            {
                return IsSetTransactTime();
            }

            public bool IsSetTransactTime()
            {
                return IsSetField(Tags.TransactTime);
            }
            public QuickFix.Fields.CxlRejResponseTo CxlRejResponseTo
            {
                get
                {
                    QuickFix.Fields.CxlRejResponseTo val = new QuickFix.Fields.CxlRejResponseTo();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CxlRejResponseTo val)
            {
                this.CxlRejResponseTo = val;
            }

            public QuickFix.Fields.CxlRejResponseTo Get(QuickFix.Fields.CxlRejResponseTo val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CxlRejResponseTo val)
            {
                return IsSetCxlRejResponseTo();
            }

            public bool IsSetCxlRejResponseTo()
            {
                return IsSetField(Tags.CxlRejResponseTo);
            }
            public QuickFix.Fields.CxlRejReason CxlRejReason
            {
                get
                {
                    QuickFix.Fields.CxlRejReason val = new QuickFix.Fields.CxlRejReason();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CxlRejReason val)
            {
                this.CxlRejReason = val;
            }

            public QuickFix.Fields.CxlRejReason Get(QuickFix.Fields.CxlRejReason val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CxlRejReason val)
            {
                return IsSetCxlRejReason();
            }

            public bool IsSetCxlRejReason()
            {
                return IsSetField(Tags.CxlRejReason);
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
            public QuickFix.Fields.ExDestination ExDestination
            {
                get
                {
                    QuickFix.Fields.ExDestination val = new QuickFix.Fields.ExDestination();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ExDestination val)
            {
                this.ExDestination = val;
            }

            public QuickFix.Fields.ExDestination Get(QuickFix.Fields.ExDestination val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ExDestination val)
            {
                return IsSetExDestination();
            }

            public bool IsSetExDestination()
            {
                return IsSetField(Tags.ExDestination);
            }
            public QuickFix.Fields.ExDestinationIDSource ExDestinationIDSource
            {
                get
                {
                    QuickFix.Fields.ExDestinationIDSource val = new QuickFix.Fields.ExDestinationIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ExDestinationIDSource val)
            {
                this.ExDestinationIDSource = val;
            }

            public QuickFix.Fields.ExDestinationIDSource Get(QuickFix.Fields.ExDestinationIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ExDestinationIDSource val)
            {
                return IsSetExDestinationIDSource();
            }

            public bool IsSetExDestinationIDSource()
            {
                return IsSetField(Tags.ExDestinationIDSource);
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
            public QuickFix.Fields.OrderRequestID OrderRequestID
            {
                get
                {
                    QuickFix.Fields.OrderRequestID val = new QuickFix.Fields.OrderRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OrderRequestID val)
            {
                this.OrderRequestID = val;
            }

            public QuickFix.Fields.OrderRequestID Get(QuickFix.Fields.OrderRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OrderRequestID val)
            {
                return IsSetOrderRequestID();
            }

            public bool IsSetOrderRequestID()
            {
                return IsSetField(Tags.OrderRequestID);
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
        }
    }
}
