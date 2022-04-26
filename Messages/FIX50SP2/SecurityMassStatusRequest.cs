// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP2
    {
        public class SecurityMassStatusRequest : Message
        {
            public const string MsgType = "CN";

            public SecurityMassStatusRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("CN"));
            }

            public SecurityMassStatusRequest(
                    QuickFix.Fields.SecurityStatusReqID aSecurityStatusReqID,
                    QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType
                ) : this()
            {
                this.SecurityStatusReqID = aSecurityStatusReqID;
                this.SubscriptionRequestType = aSubscriptionRequestType;
            }

            public QuickFix.Fields.SecurityStatusReqID SecurityStatusReqID
            {
                get
                {
                    QuickFix.Fields.SecurityStatusReqID val = new QuickFix.Fields.SecurityStatusReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityStatusReqID val)
            {
                this.SecurityStatusReqID = val;
            }

            public QuickFix.Fields.SecurityStatusReqID Get(QuickFix.Fields.SecurityStatusReqID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityStatusReqID val)
            {
                return IsSetSecurityStatusReqID();
            }

            public bool IsSetSecurityStatusReqID()
            {
                return IsSetField(Tags.SecurityStatusReqID);
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
            public QuickFix.Fields.SubscriptionRequestType SubscriptionRequestType
            {
                get
                {
                    QuickFix.Fields.SubscriptionRequestType val = new QuickFix.Fields.SubscriptionRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SubscriptionRequestType val)
            {
                this.SubscriptionRequestType = val;
            }

            public QuickFix.Fields.SubscriptionRequestType Get(QuickFix.Fields.SubscriptionRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SubscriptionRequestType val)
            {
                return IsSetSubscriptionRequestType();
            }

            public bool IsSetSubscriptionRequestType()
            {
                return IsSetField(Tags.SubscriptionRequestType);
            }
            public QuickFix.Fields.SecurityListID SecurityListID
            {
                get
                {
                    QuickFix.Fields.SecurityListID val = new QuickFix.Fields.SecurityListID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityListID val)
            {
                this.SecurityListID = val;
            }

            public QuickFix.Fields.SecurityListID Get(QuickFix.Fields.SecurityListID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityListID val)
            {
                return IsSetSecurityListID();
            }

            public bool IsSetSecurityListID()
            {
                return IsSetField(Tags.SecurityListID);
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
            public QuickFix.Fields.TradingSessionID TradingSessionID
            {
                get
                {
                    QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingSessionID val)
            {
                this.TradingSessionID = val;
            }

            public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingSessionID val)
            {
                return IsSetTradingSessionID();
            }

            public bool IsSetTradingSessionID()
            {
                return IsSetField(Tags.TradingSessionID);
            }
            public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
            {
                get
                {
                    QuickFix.Fields.TradingSessionSubID val = new QuickFix.Fields.TradingSessionSubID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.TradingSessionSubID val)
            {
                this.TradingSessionSubID = val;
            }

            public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.TradingSessionSubID val)
            {
                return IsSetTradingSessionSubID();
            }

            public bool IsSetTradingSessionSubID()
            {
                return IsSetField(Tags.TradingSessionSubID);
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
