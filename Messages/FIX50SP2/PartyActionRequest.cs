// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class PartyActionRequest : Message
        {
            public const string MsgType = "DH";

            public PartyActionRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("DH"));
            }

            public PartyActionRequest(
                    QuickFix.Fields.PartyActionRequestID aPartyActionRequestID,
                    QuickFix.Fields.PartyActionType aPartyActionType
                ) : this()
            {
                this.PartyActionRequestID = aPartyActionRequestID;
                this.PartyActionType = aPartyActionType;
            }

            public QuickFix.Fields.PartyActionRequestID PartyActionRequestID
            {
                get
                {
                    QuickFix.Fields.PartyActionRequestID val = new QuickFix.Fields.PartyActionRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PartyActionRequestID val)
            {
                this.PartyActionRequestID = val;
            }

            public QuickFix.Fields.PartyActionRequestID Get(QuickFix.Fields.PartyActionRequestID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PartyActionRequestID val)
            {
                return IsSetPartyActionRequestID();
            }

            public bool IsSetPartyActionRequestID()
            {
                return IsSetField(Tags.PartyActionRequestID);
            }
            public QuickFix.Fields.PartyActionType PartyActionType
            {
                get
                {
                    QuickFix.Fields.PartyActionType val = new QuickFix.Fields.PartyActionType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PartyActionType val)
            {
                this.PartyActionType = val;
            }

            public QuickFix.Fields.PartyActionType Get(QuickFix.Fields.PartyActionType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PartyActionType val)
            {
                return IsSetPartyActionType();
            }

            public bool IsSetPartyActionType()
            {
                return IsSetField(Tags.PartyActionType);
            }
            public QuickFix.Fields.ApplTestMessageIndicator ApplTestMessageIndicator
            {
                get
                {
                    QuickFix.Fields.ApplTestMessageIndicator val = new QuickFix.Fields.ApplTestMessageIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ApplTestMessageIndicator val)
            {
                this.ApplTestMessageIndicator = val;
            }

            public QuickFix.Fields.ApplTestMessageIndicator Get(QuickFix.Fields.ApplTestMessageIndicator val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ApplTestMessageIndicator val)
            {
                return IsSetApplTestMessageIndicator();
            }

            public bool IsSetApplTestMessageIndicator()
            {
                return IsSetField(Tags.ApplTestMessageIndicator);
            }
            public QuickFix.Fields.NoRequestingPartyIDs NoRequestingPartyIDs
            {
                get
                {
                    QuickFix.Fields.NoRequestingPartyIDs val = new QuickFix.Fields.NoRequestingPartyIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRequestingPartyIDs val)
            {
                this.NoRequestingPartyIDs = val;
            }

            public QuickFix.Fields.NoRequestingPartyIDs Get(QuickFix.Fields.NoRequestingPartyIDs val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRequestingPartyIDs val)
            {
                return IsSetNoRequestingPartyIDs();
            }

            public bool IsSetNoRequestingPartyIDs()
            {
                return IsSetField(Tags.NoRequestingPartyIDs);
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
            public QuickFix.Fields.NoRelatedPartyDetailID NoRelatedPartyDetailID
            {
                get
                {
                    QuickFix.Fields.NoRelatedPartyDetailID val = new QuickFix.Fields.NoRelatedPartyDetailID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoRelatedPartyDetailID val)
            {
                this.NoRelatedPartyDetailID = val;
            }

            public QuickFix.Fields.NoRelatedPartyDetailID Get(QuickFix.Fields.NoRelatedPartyDetailID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailID val)
            {
                return IsSetNoRelatedPartyDetailID();
            }

            public bool IsSetNoRelatedPartyDetailID()
            {
                return IsSetField(Tags.NoRelatedPartyDetailID);
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
            public QuickFix.Fields.MarketID MarketID
            {
                get
                {
                    QuickFix.Fields.MarketID val = new QuickFix.Fields.MarketID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketID val)
            {
                this.MarketID = val;
            }

            public QuickFix.Fields.MarketID Get(QuickFix.Fields.MarketID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketID val)
            {
                return IsSetMarketID();
            }

            public bool IsSetMarketID()
            {
                return IsSetField(Tags.MarketID);
            }
            public QuickFix.Fields.MarketSegmentID MarketSegmentID
            {
                get
                {
                    QuickFix.Fields.MarketSegmentID val = new QuickFix.Fields.MarketSegmentID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MarketSegmentID val)
            {
                this.MarketSegmentID = val;
            }

            public QuickFix.Fields.MarketSegmentID Get(QuickFix.Fields.MarketSegmentID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MarketSegmentID val)
            {
                return IsSetMarketSegmentID();
            }

            public bool IsSetMarketSegmentID()
            {
                return IsSetField(Tags.MarketSegmentID);
            }
            public QuickFix.Fields.InstrumentScopeSymbol InstrumentScopeSymbol
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSymbol val = new QuickFix.Fields.InstrumentScopeSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSymbol val)
            {
                this.InstrumentScopeSymbol = val;
            }

            public QuickFix.Fields.InstrumentScopeSymbol Get(QuickFix.Fields.InstrumentScopeSymbol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSymbol val)
            {
                return IsSetInstrumentScopeSymbol();
            }

            public bool IsSetInstrumentScopeSymbol()
            {
                return IsSetField(Tags.InstrumentScopeSymbol);
            }
            public QuickFix.Fields.InstrumentScopeSymbolSfx InstrumentScopeSymbolSfx
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSymbolSfx val = new QuickFix.Fields.InstrumentScopeSymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSymbolSfx val)
            {
                this.InstrumentScopeSymbolSfx = val;
            }

            public QuickFix.Fields.InstrumentScopeSymbolSfx Get(QuickFix.Fields.InstrumentScopeSymbolSfx val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSymbolSfx val)
            {
                return IsSetInstrumentScopeSymbolSfx();
            }

            public bool IsSetInstrumentScopeSymbolSfx()
            {
                return IsSetField(Tags.InstrumentScopeSymbolSfx);
            }
            public QuickFix.Fields.InstrumentScopeSecurityID InstrumentScopeSecurityID
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecurityID val = new QuickFix.Fields.InstrumentScopeSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecurityID val)
            {
                this.InstrumentScopeSecurityID = val;
            }

            public QuickFix.Fields.InstrumentScopeSecurityID Get(QuickFix.Fields.InstrumentScopeSecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityID val)
            {
                return IsSetInstrumentScopeSecurityID();
            }

            public bool IsSetInstrumentScopeSecurityID()
            {
                return IsSetField(Tags.InstrumentScopeSecurityID);
            }
            public QuickFix.Fields.InstrumentScopeSecurityIDSource InstrumentScopeSecurityIDSource
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecurityIDSource val = new QuickFix.Fields.InstrumentScopeSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecurityIDSource val)
            {
                this.InstrumentScopeSecurityIDSource = val;
            }

            public QuickFix.Fields.InstrumentScopeSecurityIDSource Get(QuickFix.Fields.InstrumentScopeSecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityIDSource val)
            {
                return IsSetInstrumentScopeSecurityIDSource();
            }

            public bool IsSetInstrumentScopeSecurityIDSource()
            {
                return IsSetField(Tags.InstrumentScopeSecurityIDSource);
            }
            public QuickFix.Fields.NoInstrumentScopeSecurityAltID NoInstrumentScopeSecurityAltID
            {
                get
                {
                    QuickFix.Fields.NoInstrumentScopeSecurityAltID val = new QuickFix.Fields.NoInstrumentScopeSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoInstrumentScopeSecurityAltID val)
            {
                this.NoInstrumentScopeSecurityAltID = val;
            }

            public QuickFix.Fields.NoInstrumentScopeSecurityAltID Get(QuickFix.Fields.NoInstrumentScopeSecurityAltID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoInstrumentScopeSecurityAltID val)
            {
                return IsSetNoInstrumentScopeSecurityAltID();
            }

            public bool IsSetNoInstrumentScopeSecurityAltID()
            {
                return IsSetField(Tags.NoInstrumentScopeSecurityAltID);
            }
            public QuickFix.Fields.InstrumentScopeProduct InstrumentScopeProduct
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeProduct val = new QuickFix.Fields.InstrumentScopeProduct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeProduct val)
            {
                this.InstrumentScopeProduct = val;
            }

            public QuickFix.Fields.InstrumentScopeProduct Get(QuickFix.Fields.InstrumentScopeProduct val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeProduct val)
            {
                return IsSetInstrumentScopeProduct();
            }

            public bool IsSetInstrumentScopeProduct()
            {
                return IsSetField(Tags.InstrumentScopeProduct);
            }
            public QuickFix.Fields.InstrumentScopeProductComplex InstrumentScopeProductComplex
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeProductComplex val = new QuickFix.Fields.InstrumentScopeProductComplex();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeProductComplex val)
            {
                this.InstrumentScopeProductComplex = val;
            }

            public QuickFix.Fields.InstrumentScopeProductComplex Get(QuickFix.Fields.InstrumentScopeProductComplex val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeProductComplex val)
            {
                return IsSetInstrumentScopeProductComplex();
            }

            public bool IsSetInstrumentScopeProductComplex()
            {
                return IsSetField(Tags.InstrumentScopeProductComplex);
            }
            public QuickFix.Fields.InstrumentScopeSecurityGroup InstrumentScopeSecurityGroup
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecurityGroup val = new QuickFix.Fields.InstrumentScopeSecurityGroup();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecurityGroup val)
            {
                this.InstrumentScopeSecurityGroup = val;
            }

            public QuickFix.Fields.InstrumentScopeSecurityGroup Get(QuickFix.Fields.InstrumentScopeSecurityGroup val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityGroup val)
            {
                return IsSetInstrumentScopeSecurityGroup();
            }

            public bool IsSetInstrumentScopeSecurityGroup()
            {
                return IsSetField(Tags.InstrumentScopeSecurityGroup);
            }
            public QuickFix.Fields.InstrumentScopeCFICode InstrumentScopeCFICode
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeCFICode val = new QuickFix.Fields.InstrumentScopeCFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeCFICode val)
            {
                this.InstrumentScopeCFICode = val;
            }

            public QuickFix.Fields.InstrumentScopeCFICode Get(QuickFix.Fields.InstrumentScopeCFICode val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeCFICode val)
            {
                return IsSetInstrumentScopeCFICode();
            }

            public bool IsSetInstrumentScopeCFICode()
            {
                return IsSetField(Tags.InstrumentScopeCFICode);
            }
            public QuickFix.Fields.InstrumentScopeSecurityType InstrumentScopeSecurityType
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecurityType val = new QuickFix.Fields.InstrumentScopeSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecurityType val)
            {
                this.InstrumentScopeSecurityType = val;
            }

            public QuickFix.Fields.InstrumentScopeSecurityType Get(QuickFix.Fields.InstrumentScopeSecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityType val)
            {
                return IsSetInstrumentScopeSecurityType();
            }

            public bool IsSetInstrumentScopeSecurityType()
            {
                return IsSetField(Tags.InstrumentScopeSecurityType);
            }
            public QuickFix.Fields.InstrumentScopeSecuritySubType InstrumentScopeSecuritySubType
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecuritySubType val = new QuickFix.Fields.InstrumentScopeSecuritySubType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecuritySubType val)
            {
                this.InstrumentScopeSecuritySubType = val;
            }

            public QuickFix.Fields.InstrumentScopeSecuritySubType Get(QuickFix.Fields.InstrumentScopeSecuritySubType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecuritySubType val)
            {
                return IsSetInstrumentScopeSecuritySubType();
            }

            public bool IsSetInstrumentScopeSecuritySubType()
            {
                return IsSetField(Tags.InstrumentScopeSecuritySubType);
            }
            public QuickFix.Fields.InstrumentScopeMaturityMonthYear InstrumentScopeMaturityMonthYear
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeMaturityMonthYear val = new QuickFix.Fields.InstrumentScopeMaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeMaturityMonthYear val)
            {
                this.InstrumentScopeMaturityMonthYear = val;
            }

            public QuickFix.Fields.InstrumentScopeMaturityMonthYear Get(QuickFix.Fields.InstrumentScopeMaturityMonthYear val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeMaturityMonthYear val)
            {
                return IsSetInstrumentScopeMaturityMonthYear();
            }

            public bool IsSetInstrumentScopeMaturityMonthYear()
            {
                return IsSetField(Tags.InstrumentScopeMaturityMonthYear);
            }
            public QuickFix.Fields.InstrumentScopeMaturityTime InstrumentScopeMaturityTime
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeMaturityTime val = new QuickFix.Fields.InstrumentScopeMaturityTime();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeMaturityTime val)
            {
                this.InstrumentScopeMaturityTime = val;
            }

            public QuickFix.Fields.InstrumentScopeMaturityTime Get(QuickFix.Fields.InstrumentScopeMaturityTime val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeMaturityTime val)
            {
                return IsSetInstrumentScopeMaturityTime();
            }

            public bool IsSetInstrumentScopeMaturityTime()
            {
                return IsSetField(Tags.InstrumentScopeMaturityTime);
            }
            public QuickFix.Fields.InstrumentScopeRestructuringType InstrumentScopeRestructuringType
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeRestructuringType val = new QuickFix.Fields.InstrumentScopeRestructuringType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeRestructuringType val)
            {
                this.InstrumentScopeRestructuringType = val;
            }

            public QuickFix.Fields.InstrumentScopeRestructuringType Get(QuickFix.Fields.InstrumentScopeRestructuringType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeRestructuringType val)
            {
                return IsSetInstrumentScopeRestructuringType();
            }

            public bool IsSetInstrumentScopeRestructuringType()
            {
                return IsSetField(Tags.InstrumentScopeRestructuringType);
            }
            public QuickFix.Fields.InstrumentScopeSeniority InstrumentScopeSeniority
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSeniority val = new QuickFix.Fields.InstrumentScopeSeniority();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSeniority val)
            {
                this.InstrumentScopeSeniority = val;
            }

            public QuickFix.Fields.InstrumentScopeSeniority Get(QuickFix.Fields.InstrumentScopeSeniority val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSeniority val)
            {
                return IsSetInstrumentScopeSeniority();
            }

            public bool IsSetInstrumentScopeSeniority()
            {
                return IsSetField(Tags.InstrumentScopeSeniority);
            }
            public QuickFix.Fields.InstrumentScopePutOrCall InstrumentScopePutOrCall
            {
                get
                {
                    QuickFix.Fields.InstrumentScopePutOrCall val = new QuickFix.Fields.InstrumentScopePutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopePutOrCall val)
            {
                this.InstrumentScopePutOrCall = val;
            }

            public QuickFix.Fields.InstrumentScopePutOrCall Get(QuickFix.Fields.InstrumentScopePutOrCall val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopePutOrCall val)
            {
                return IsSetInstrumentScopePutOrCall();
            }

            public bool IsSetInstrumentScopePutOrCall()
            {
                return IsSetField(Tags.InstrumentScopePutOrCall);
            }
            public QuickFix.Fields.InstrumentScopeFlexibleIndicator InstrumentScopeFlexibleIndicator
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeFlexibleIndicator val = new QuickFix.Fields.InstrumentScopeFlexibleIndicator();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeFlexibleIndicator val)
            {
                this.InstrumentScopeFlexibleIndicator = val;
            }

            public QuickFix.Fields.InstrumentScopeFlexibleIndicator Get(QuickFix.Fields.InstrumentScopeFlexibleIndicator val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeFlexibleIndicator val)
            {
                return IsSetInstrumentScopeFlexibleIndicator();
            }

            public bool IsSetInstrumentScopeFlexibleIndicator()
            {
                return IsSetField(Tags.InstrumentScopeFlexibleIndicator);
            }
            public QuickFix.Fields.InstrumentScopeCouponRate InstrumentScopeCouponRate
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeCouponRate val = new QuickFix.Fields.InstrumentScopeCouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeCouponRate val)
            {
                this.InstrumentScopeCouponRate = val;
            }

            public QuickFix.Fields.InstrumentScopeCouponRate Get(QuickFix.Fields.InstrumentScopeCouponRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeCouponRate val)
            {
                return IsSetInstrumentScopeCouponRate();
            }

            public bool IsSetInstrumentScopeCouponRate()
            {
                return IsSetField(Tags.InstrumentScopeCouponRate);
            }
            public QuickFix.Fields.InstrumentScopeSecurityExchange InstrumentScopeSecurityExchange
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecurityExchange val = new QuickFix.Fields.InstrumentScopeSecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecurityExchange val)
            {
                this.InstrumentScopeSecurityExchange = val;
            }

            public QuickFix.Fields.InstrumentScopeSecurityExchange Get(QuickFix.Fields.InstrumentScopeSecurityExchange val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityExchange val)
            {
                return IsSetInstrumentScopeSecurityExchange();
            }

            public bool IsSetInstrumentScopeSecurityExchange()
            {
                return IsSetField(Tags.InstrumentScopeSecurityExchange);
            }
            public QuickFix.Fields.InstrumentScopeSecurityDesc InstrumentScopeSecurityDesc
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSecurityDesc val = new QuickFix.Fields.InstrumentScopeSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSecurityDesc val)
            {
                this.InstrumentScopeSecurityDesc = val;
            }

            public QuickFix.Fields.InstrumentScopeSecurityDesc Get(QuickFix.Fields.InstrumentScopeSecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityDesc val)
            {
                return IsSetInstrumentScopeSecurityDesc();
            }

            public bool IsSetInstrumentScopeSecurityDesc()
            {
                return IsSetField(Tags.InstrumentScopeSecurityDesc);
            }
            public QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen InstrumentScopeEncodedSecurityDescLen
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val = new QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val)
            {
                this.InstrumentScopeEncodedSecurityDescLen = val;
            }

            public QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen Get(QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeEncodedSecurityDescLen val)
            {
                return IsSetInstrumentScopeEncodedSecurityDescLen();
            }

            public bool IsSetInstrumentScopeEncodedSecurityDescLen()
            {
                return IsSetField(Tags.InstrumentScopeEncodedSecurityDescLen);
            }
            public QuickFix.Fields.InstrumentScopeEncodedSecurityDesc InstrumentScopeEncodedSecurityDesc
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val = new QuickFix.Fields.InstrumentScopeEncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val)
            {
                this.InstrumentScopeEncodedSecurityDesc = val;
            }

            public QuickFix.Fields.InstrumentScopeEncodedSecurityDesc Get(QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeEncodedSecurityDesc val)
            {
                return IsSetInstrumentScopeEncodedSecurityDesc();
            }

            public bool IsSetInstrumentScopeEncodedSecurityDesc()
            {
                return IsSetField(Tags.InstrumentScopeEncodedSecurityDesc);
            }
            public QuickFix.Fields.InstrumentScopeSettlType InstrumentScopeSettlType
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeSettlType val = new QuickFix.Fields.InstrumentScopeSettlType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeSettlType val)
            {
                this.InstrumentScopeSettlType = val;
            }

            public QuickFix.Fields.InstrumentScopeSettlType Get(QuickFix.Fields.InstrumentScopeSettlType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeSettlType val)
            {
                return IsSetInstrumentScopeSettlType();
            }

            public bool IsSetInstrumentScopeSettlType()
            {
                return IsSetField(Tags.InstrumentScopeSettlType);
            }
            public QuickFix.Fields.InstrumentScopeUPICode InstrumentScopeUPICode
            {
                get
                {
                    QuickFix.Fields.InstrumentScopeUPICode val = new QuickFix.Fields.InstrumentScopeUPICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrumentScopeUPICode val)
            {
                this.InstrumentScopeUPICode = val;
            }

            public QuickFix.Fields.InstrumentScopeUPICode Get(QuickFix.Fields.InstrumentScopeUPICode val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrumentScopeUPICode val)
            {
                return IsSetInstrumentScopeUPICode();
            }

            public bool IsSetInstrumentScopeUPICode()
            {
                return IsSetField(Tags.InstrumentScopeUPICode);
            }
            public class NoRequestingPartyIDsGroup : Group
            {
                public static int[] fieldOrder = { Tags.RequestingPartyID, Tags.RequestingPartyIDSource, Tags.RequestingPartyRole, Tags.NoRequestingPartySubIDs, Tags.RequestingPartyRoleQualifier, 0 };

                public NoRequestingPartyIDsGroup()
                  : base(Tags.NoRequestingPartyIDs, Tags.RequestingPartyID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRequestingPartyIDsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.RequestingPartyID RequestingPartyID
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyID val = new QuickFix.Fields.RequestingPartyID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyID val)
                {
                    this.RequestingPartyID = val;
                }

                public QuickFix.Fields.RequestingPartyID Get(QuickFix.Fields.RequestingPartyID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyID val)
                {
                    return IsSetRequestingPartyID();
                }

                public bool IsSetRequestingPartyID()
                {
                    return IsSetField(Tags.RequestingPartyID);
                }
                public QuickFix.Fields.RequestingPartyIDSource RequestingPartyIDSource
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyIDSource val = new QuickFix.Fields.RequestingPartyIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyIDSource val)
                {
                    this.RequestingPartyIDSource = val;
                }

                public QuickFix.Fields.RequestingPartyIDSource Get(QuickFix.Fields.RequestingPartyIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyIDSource val)
                {
                    return IsSetRequestingPartyIDSource();
                }

                public bool IsSetRequestingPartyIDSource()
                {
                    return IsSetField(Tags.RequestingPartyIDSource);
                }
                public QuickFix.Fields.RequestingPartyRole RequestingPartyRole
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyRole val = new QuickFix.Fields.RequestingPartyRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyRole val)
                {
                    this.RequestingPartyRole = val;
                }

                public QuickFix.Fields.RequestingPartyRole Get(QuickFix.Fields.RequestingPartyRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyRole val)
                {
                    return IsSetRequestingPartyRole();
                }

                public bool IsSetRequestingPartyRole()
                {
                    return IsSetField(Tags.RequestingPartyRole);
                }
                public QuickFix.Fields.NoRequestingPartySubIDs NoRequestingPartySubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoRequestingPartySubIDs val = new QuickFix.Fields.NoRequestingPartySubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoRequestingPartySubIDs val)
                {
                    this.NoRequestingPartySubIDs = val;
                }

                public QuickFix.Fields.NoRequestingPartySubIDs Get(QuickFix.Fields.NoRequestingPartySubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoRequestingPartySubIDs val)
                {
                    return IsSetNoRequestingPartySubIDs();
                }

                public bool IsSetNoRequestingPartySubIDs()
                {
                    return IsSetField(Tags.NoRequestingPartySubIDs);
                }
                public QuickFix.Fields.RequestingPartyRoleQualifier RequestingPartyRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.RequestingPartyRoleQualifier val = new QuickFix.Fields.RequestingPartyRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RequestingPartyRoleQualifier val)
                {
                    this.RequestingPartyRoleQualifier = val;
                }

                public QuickFix.Fields.RequestingPartyRoleQualifier Get(QuickFix.Fields.RequestingPartyRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RequestingPartyRoleQualifier val)
                {
                    return IsSetRequestingPartyRoleQualifier();
                }

                public bool IsSetRequestingPartyRoleQualifier()
                {
                    return IsSetField(Tags.RequestingPartyRoleQualifier);
                }
                public class NoRequestingPartySubIDsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.RequestingPartySubID, Tags.RequestingPartySubIDType, 0 };

                    public NoRequestingPartySubIDsGroup()
                      : base(Tags.NoRequestingPartySubIDs, Tags.RequestingPartySubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRequestingPartySubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.RequestingPartySubID RequestingPartySubID
                    {
                        get
                        {
                            QuickFix.Fields.RequestingPartySubID val = new QuickFix.Fields.RequestingPartySubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RequestingPartySubID val)
                    {
                        this.RequestingPartySubID = val;
                    }

                    public QuickFix.Fields.RequestingPartySubID Get(QuickFix.Fields.RequestingPartySubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RequestingPartySubID val)
                    {
                        return IsSetRequestingPartySubID();
                    }

                    public bool IsSetRequestingPartySubID()
                    {
                        return IsSetField(Tags.RequestingPartySubID);
                    }
                    public QuickFix.Fields.RequestingPartySubIDType RequestingPartySubIDType
                    {
                        get
                        {
                            QuickFix.Fields.RequestingPartySubIDType val = new QuickFix.Fields.RequestingPartySubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RequestingPartySubIDType val)
                    {
                        this.RequestingPartySubIDType = val;
                    }

                    public QuickFix.Fields.RequestingPartySubIDType Get(QuickFix.Fields.RequestingPartySubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RequestingPartySubIDType val)
                    {
                        return IsSetRequestingPartySubIDType();
                    }

                    public bool IsSetRequestingPartySubIDType()
                    {
                        return IsSetField(Tags.RequestingPartySubIDType);
                    }

                }
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
            public class NoRelatedPartyDetailIDGroup : Group
            {
                public static int[] fieldOrder = { Tags.RelatedPartyDetailID, Tags.RelatedPartyDetailIDSource, Tags.RelatedPartyDetailRole, Tags.RelatedPartyDetailRoleQualifier, Tags.NoRelatedPartyDetailSubIDs, Tags.NoRelatedPartyDetailAltID, Tags.NoPartyRelationships, 0 };

                public NoRelatedPartyDetailIDGroup()
                  : base(Tags.NoRelatedPartyDetailID, Tags.RelatedPartyDetailID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoRelatedPartyDetailIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.RelatedPartyDetailID RelatedPartyDetailID
                {
                    get
                    {
                        QuickFix.Fields.RelatedPartyDetailID val = new QuickFix.Fields.RelatedPartyDetailID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RelatedPartyDetailID val)
                {
                    this.RelatedPartyDetailID = val;
                }

                public QuickFix.Fields.RelatedPartyDetailID Get(QuickFix.Fields.RelatedPartyDetailID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RelatedPartyDetailID val)
                {
                    return IsSetRelatedPartyDetailID();
                }

                public bool IsSetRelatedPartyDetailID()
                {
                    return IsSetField(Tags.RelatedPartyDetailID);
                }
                public QuickFix.Fields.RelatedPartyDetailIDSource RelatedPartyDetailIDSource
                {
                    get
                    {
                        QuickFix.Fields.RelatedPartyDetailIDSource val = new QuickFix.Fields.RelatedPartyDetailIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RelatedPartyDetailIDSource val)
                {
                    this.RelatedPartyDetailIDSource = val;
                }

                public QuickFix.Fields.RelatedPartyDetailIDSource Get(QuickFix.Fields.RelatedPartyDetailIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RelatedPartyDetailIDSource val)
                {
                    return IsSetRelatedPartyDetailIDSource();
                }

                public bool IsSetRelatedPartyDetailIDSource()
                {
                    return IsSetField(Tags.RelatedPartyDetailIDSource);
                }
                public QuickFix.Fields.RelatedPartyDetailRole RelatedPartyDetailRole
                {
                    get
                    {
                        QuickFix.Fields.RelatedPartyDetailRole val = new QuickFix.Fields.RelatedPartyDetailRole();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RelatedPartyDetailRole val)
                {
                    this.RelatedPartyDetailRole = val;
                }

                public QuickFix.Fields.RelatedPartyDetailRole Get(QuickFix.Fields.RelatedPartyDetailRole val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RelatedPartyDetailRole val)
                {
                    return IsSetRelatedPartyDetailRole();
                }

                public bool IsSetRelatedPartyDetailRole()
                {
                    return IsSetField(Tags.RelatedPartyDetailRole);
                }
                public QuickFix.Fields.RelatedPartyDetailRoleQualifier RelatedPartyDetailRoleQualifier
                {
                    get
                    {
                        QuickFix.Fields.RelatedPartyDetailRoleQualifier val = new QuickFix.Fields.RelatedPartyDetailRoleQualifier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.RelatedPartyDetailRoleQualifier val)
                {
                    this.RelatedPartyDetailRoleQualifier = val;
                }

                public QuickFix.Fields.RelatedPartyDetailRoleQualifier Get(QuickFix.Fields.RelatedPartyDetailRoleQualifier val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.RelatedPartyDetailRoleQualifier val)
                {
                    return IsSetRelatedPartyDetailRoleQualifier();
                }

                public bool IsSetRelatedPartyDetailRoleQualifier()
                {
                    return IsSetField(Tags.RelatedPartyDetailRoleQualifier);
                }
                public QuickFix.Fields.NoRelatedPartyDetailSubIDs NoRelatedPartyDetailSubIDs
                {
                    get
                    {
                        QuickFix.Fields.NoRelatedPartyDetailSubIDs val = new QuickFix.Fields.NoRelatedPartyDetailSubIDs();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoRelatedPartyDetailSubIDs val)
                {
                    this.NoRelatedPartyDetailSubIDs = val;
                }

                public QuickFix.Fields.NoRelatedPartyDetailSubIDs Get(QuickFix.Fields.NoRelatedPartyDetailSubIDs val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailSubIDs val)
                {
                    return IsSetNoRelatedPartyDetailSubIDs();
                }

                public bool IsSetNoRelatedPartyDetailSubIDs()
                {
                    return IsSetField(Tags.NoRelatedPartyDetailSubIDs);
                }
                public QuickFix.Fields.NoRelatedPartyDetailAltID NoRelatedPartyDetailAltID
                {
                    get
                    {
                        QuickFix.Fields.NoRelatedPartyDetailAltID val = new QuickFix.Fields.NoRelatedPartyDetailAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoRelatedPartyDetailAltID val)
                {
                    this.NoRelatedPartyDetailAltID = val;
                }

                public QuickFix.Fields.NoRelatedPartyDetailAltID Get(QuickFix.Fields.NoRelatedPartyDetailAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailAltID val)
                {
                    return IsSetNoRelatedPartyDetailAltID();
                }

                public bool IsSetNoRelatedPartyDetailAltID()
                {
                    return IsSetField(Tags.NoRelatedPartyDetailAltID);
                }
                public QuickFix.Fields.NoPartyRelationships NoPartyRelationships
                {
                    get
                    {
                        QuickFix.Fields.NoPartyRelationships val = new QuickFix.Fields.NoPartyRelationships();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NoPartyRelationships val)
                {
                    this.NoPartyRelationships = val;
                }

                public QuickFix.Fields.NoPartyRelationships Get(QuickFix.Fields.NoPartyRelationships val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NoPartyRelationships val)
                {
                    return IsSetNoPartyRelationships();
                }

                public bool IsSetNoPartyRelationships()
                {
                    return IsSetField(Tags.NoPartyRelationships);
                }
                public class NoRelatedPartyDetailSubIDsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.RelatedPartyDetailSubID, Tags.RelatedPartyDetailSubIDType, 0 };

                    public NoRelatedPartyDetailSubIDsGroup()
                      : base(Tags.NoRelatedPartyDetailSubIDs, Tags.RelatedPartyDetailSubID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRelatedPartyDetailSubIDsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.RelatedPartyDetailSubID RelatedPartyDetailSubID
                    {
                        get
                        {
                            QuickFix.Fields.RelatedPartyDetailSubID val = new QuickFix.Fields.RelatedPartyDetailSubID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RelatedPartyDetailSubID val)
                    {
                        this.RelatedPartyDetailSubID = val;
                    }

                    public QuickFix.Fields.RelatedPartyDetailSubID Get(QuickFix.Fields.RelatedPartyDetailSubID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RelatedPartyDetailSubID val)
                    {
                        return IsSetRelatedPartyDetailSubID();
                    }

                    public bool IsSetRelatedPartyDetailSubID()
                    {
                        return IsSetField(Tags.RelatedPartyDetailSubID);
                    }
                    public QuickFix.Fields.RelatedPartyDetailSubIDType RelatedPartyDetailSubIDType
                    {
                        get
                        {
                            QuickFix.Fields.RelatedPartyDetailSubIDType val = new QuickFix.Fields.RelatedPartyDetailSubIDType();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RelatedPartyDetailSubIDType val)
                    {
                        this.RelatedPartyDetailSubIDType = val;
                    }

                    public QuickFix.Fields.RelatedPartyDetailSubIDType Get(QuickFix.Fields.RelatedPartyDetailSubIDType val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RelatedPartyDetailSubIDType val)
                    {
                        return IsSetRelatedPartyDetailSubIDType();
                    }

                    public bool IsSetRelatedPartyDetailSubIDType()
                    {
                        return IsSetField(Tags.RelatedPartyDetailSubIDType);
                    }

                }
                public class NoRelatedPartyDetailAltIDGroup : Group
                {
                    public static int[] fieldOrder = { Tags.RelatedPartyDetailAltID, Tags.RelatedPartyDetailAltIDSource, Tags.NoRelatedPartyDetailAltSubIDs, 0 };

                    public NoRelatedPartyDetailAltIDGroup()
                      : base(Tags.NoRelatedPartyDetailAltID, Tags.RelatedPartyDetailAltID, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoRelatedPartyDetailAltIDGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.RelatedPartyDetailAltID RelatedPartyDetailAltID
                    {
                        get
                        {
                            QuickFix.Fields.RelatedPartyDetailAltID val = new QuickFix.Fields.RelatedPartyDetailAltID();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RelatedPartyDetailAltID val)
                    {
                        this.RelatedPartyDetailAltID = val;
                    }

                    public QuickFix.Fields.RelatedPartyDetailAltID Get(QuickFix.Fields.RelatedPartyDetailAltID val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltID val)
                    {
                        return IsSetRelatedPartyDetailAltID();
                    }

                    public bool IsSetRelatedPartyDetailAltID()
                    {
                        return IsSetField(Tags.RelatedPartyDetailAltID);
                    }
                    public QuickFix.Fields.RelatedPartyDetailAltIDSource RelatedPartyDetailAltIDSource
                    {
                        get
                        {
                            QuickFix.Fields.RelatedPartyDetailAltIDSource val = new QuickFix.Fields.RelatedPartyDetailAltIDSource();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.RelatedPartyDetailAltIDSource val)
                    {
                        this.RelatedPartyDetailAltIDSource = val;
                    }

                    public QuickFix.Fields.RelatedPartyDetailAltIDSource Get(QuickFix.Fields.RelatedPartyDetailAltIDSource val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltIDSource val)
                    {
                        return IsSetRelatedPartyDetailAltIDSource();
                    }

                    public bool IsSetRelatedPartyDetailAltIDSource()
                    {
                        return IsSetField(Tags.RelatedPartyDetailAltIDSource);
                    }
                    public QuickFix.Fields.NoRelatedPartyDetailAltSubIDs NoRelatedPartyDetailAltSubIDs
                    {
                        get
                        {
                            QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val = new QuickFix.Fields.NoRelatedPartyDetailAltSubIDs();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val)
                    {
                        this.NoRelatedPartyDetailAltSubIDs = val;
                    }

                    public QuickFix.Fields.NoRelatedPartyDetailAltSubIDs Get(QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.NoRelatedPartyDetailAltSubIDs val)
                    {
                        return IsSetNoRelatedPartyDetailAltSubIDs();
                    }

                    public bool IsSetNoRelatedPartyDetailAltSubIDs()
                    {
                        return IsSetField(Tags.NoRelatedPartyDetailAltSubIDs);
                    }
                    public class NoRelatedPartyDetailAltSubIDsGroup : Group
                    {
                        public static int[] fieldOrder = { Tags.RelatedPartyDetailAltSubID, Tags.RelatedPartyDetailAltSubIDType, 0 };

                        public NoRelatedPartyDetailAltSubIDsGroup()
                          : base(Tags.NoRelatedPartyDetailAltSubIDs, Tags.RelatedPartyDetailAltSubID, fieldOrder)
                        {
                        }

                        public override Group Clone()
                        {
                            var clone = new NoRelatedPartyDetailAltSubIDsGroup();
                            clone.CopyStateFrom(this);
                            return clone;
                        }

                        public QuickFix.Fields.RelatedPartyDetailAltSubID RelatedPartyDetailAltSubID
                        {
                            get
                            {
                                QuickFix.Fields.RelatedPartyDetailAltSubID val = new QuickFix.Fields.RelatedPartyDetailAltSubID();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RelatedPartyDetailAltSubID val)
                        {
                            this.RelatedPartyDetailAltSubID = val;
                        }

                        public QuickFix.Fields.RelatedPartyDetailAltSubID Get(QuickFix.Fields.RelatedPartyDetailAltSubID val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltSubID val)
                        {
                            return IsSetRelatedPartyDetailAltSubID();
                        }

                        public bool IsSetRelatedPartyDetailAltSubID()
                        {
                            return IsSetField(Tags.RelatedPartyDetailAltSubID);
                        }
                        public QuickFix.Fields.RelatedPartyDetailAltSubIDType RelatedPartyDetailAltSubIDType
                        {
                            get
                            {
                                QuickFix.Fields.RelatedPartyDetailAltSubIDType val = new QuickFix.Fields.RelatedPartyDetailAltSubIDType();
                                GetField(val);
                                return val;
                            }
                            set { SetField(value); }
                        }

                        public void Set(QuickFix.Fields.RelatedPartyDetailAltSubIDType val)
                        {
                            this.RelatedPartyDetailAltSubIDType = val;
                        }

                        public QuickFix.Fields.RelatedPartyDetailAltSubIDType Get(QuickFix.Fields.RelatedPartyDetailAltSubIDType val)
                        {
                            GetField(val);
                            return val;
                        }

                        public bool IsSet(QuickFix.Fields.RelatedPartyDetailAltSubIDType val)
                        {
                            return IsSetRelatedPartyDetailAltSubIDType();
                        }

                        public bool IsSetRelatedPartyDetailAltSubIDType()
                        {
                            return IsSetField(Tags.RelatedPartyDetailAltSubIDType);
                        }

                    }
                }
                public class NoPartyRelationshipsGroup : Group
                {
                    public static int[] fieldOrder = { Tags.PartyRelationship, 0 };

                    public NoPartyRelationshipsGroup()
                      : base(Tags.NoPartyRelationships, Tags.PartyRelationship, fieldOrder)
                    {
                    }

                    public override Group Clone()
                    {
                        var clone = new NoPartyRelationshipsGroup();
                        clone.CopyStateFrom(this);
                        return clone;
                    }

                    public QuickFix.Fields.PartyRelationship PartyRelationship
                    {
                        get
                        {
                            QuickFix.Fields.PartyRelationship val = new QuickFix.Fields.PartyRelationship();
                            GetField(val);
                            return val;
                        }
                        set { SetField(value); }
                    }

                    public void Set(QuickFix.Fields.PartyRelationship val)
                    {
                        this.PartyRelationship = val;
                    }

                    public QuickFix.Fields.PartyRelationship Get(QuickFix.Fields.PartyRelationship val)
                    {
                        GetField(val);
                        return val;
                    }

                    public bool IsSet(QuickFix.Fields.PartyRelationship val)
                    {
                        return IsSetPartyRelationship();
                    }

                    public bool IsSetPartyRelationship()
                    {
                        return IsSetField(Tags.PartyRelationship);
                    }

                }
            }
            public class NoInstrumentScopeSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = { Tags.InstrumentScopeSecurityAltID, Tags.InstrumentScopeSecurityAltIDSource, 0 };

                public NoInstrumentScopeSecurityAltIDGroup()
                  : base(Tags.NoInstrumentScopeSecurityAltID, Tags.InstrumentScopeSecurityAltID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoInstrumentScopeSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.InstrumentScopeSecurityAltID InstrumentScopeSecurityAltID
                {
                    get
                    {
                        QuickFix.Fields.InstrumentScopeSecurityAltID val = new QuickFix.Fields.InstrumentScopeSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.InstrumentScopeSecurityAltID val)
                {
                    this.InstrumentScopeSecurityAltID = val;
                }

                public QuickFix.Fields.InstrumentScopeSecurityAltID Get(QuickFix.Fields.InstrumentScopeSecurityAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityAltID val)
                {
                    return IsSetInstrumentScopeSecurityAltID();
                }

                public bool IsSetInstrumentScopeSecurityAltID()
                {
                    return IsSetField(Tags.InstrumentScopeSecurityAltID);
                }
                public QuickFix.Fields.InstrumentScopeSecurityAltIDSource InstrumentScopeSecurityAltIDSource
                {
                    get
                    {
                        QuickFix.Fields.InstrumentScopeSecurityAltIDSource val = new QuickFix.Fields.InstrumentScopeSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.InstrumentScopeSecurityAltIDSource val)
                {
                    this.InstrumentScopeSecurityAltIDSource = val;
                }

                public QuickFix.Fields.InstrumentScopeSecurityAltIDSource Get(QuickFix.Fields.InstrumentScopeSecurityAltIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.InstrumentScopeSecurityAltIDSource val)
                {
                    return IsSetInstrumentScopeSecurityAltIDSource();
                }

                public bool IsSetInstrumentScopeSecurityAltIDSource()
                {
                    return IsSetField(Tags.InstrumentScopeSecurityAltIDSource);
                }

            }
        }
    }
}
