// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42
    {
        public class SecurityStatusRequest : Message
        {
            public const string MsgType = "e";

            public SecurityStatusRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("e"));
            }

            public SecurityStatusRequest(
                    QuickFix.Fields.SecurityStatusReqID aSecurityStatusReqID,
                    QuickFix.Fields.Symbol aSymbol,
                    QuickFix.Fields.SubscriptionRequestType aSubscriptionRequestType
                ) : this()
            {
                this.SecurityStatusReqID = aSecurityStatusReqID;
                this.Symbol = aSymbol;
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
            public QuickFix.Fields.Symbol Symbol
            {
                get
                {
                    QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Symbol val)
            {
                this.Symbol = val;
            }

            public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Symbol val)
            {
                return IsSetSymbol();
            }

            public bool IsSetSymbol()
            {
                return IsSetField(Tags.Symbol);
            }
            public QuickFix.Fields.SymbolSfx SymbolSfx
            {
                get
                {
                    QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SymbolSfx val)
            {
                this.SymbolSfx = val;
            }

            public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SymbolSfx val)
            {
                return IsSetSymbolSfx();
            }

            public bool IsSetSymbolSfx()
            {
                return IsSetField(Tags.SymbolSfx);
            }
            public QuickFix.Fields.SecurityID SecurityID
            {
                get
                {
                    QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityID val)
            {
                this.SecurityID = val;
            }

            public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityID val)
            {
                return IsSetSecurityID();
            }

            public bool IsSetSecurityID()
            {
                return IsSetField(Tags.SecurityID);
            }
            public QuickFix.Fields.IDSource IDSource
            {
                get
                {
                    QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.IDSource val)
            {
                this.IDSource = val;
            }

            public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.IDSource val)
            {
                return IsSetIDSource();
            }

            public bool IsSetIDSource()
            {
                return IsSetField(Tags.IDSource);
            }
            public QuickFix.Fields.SecurityType SecurityType
            {
                get
                {
                    QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityType val)
            {
                this.SecurityType = val;
            }

            public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityType val)
            {
                return IsSetSecurityType();
            }

            public bool IsSetSecurityType()
            {
                return IsSetField(Tags.SecurityType);
            }
            public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
            {
                get
                {
                    QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaturityMonthYear val)
            {
                this.MaturityMonthYear = val;
            }

            public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaturityMonthYear val)
            {
                return IsSetMaturityMonthYear();
            }

            public bool IsSetMaturityMonthYear()
            {
                return IsSetField(Tags.MaturityMonthYear);
            }
            public QuickFix.Fields.MaturityDay MaturityDay
            {
                get
                {
                    QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaturityDay val)
            {
                this.MaturityDay = val;
            }

            public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaturityDay val)
            {
                return IsSetMaturityDay();
            }

            public bool IsSetMaturityDay()
            {
                return IsSetField(Tags.MaturityDay);
            }
            public QuickFix.Fields.PutOrCall PutOrCall
            {
                get
                {
                    QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.PutOrCall val)
            {
                this.PutOrCall = val;
            }

            public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.PutOrCall val)
            {
                return IsSetPutOrCall();
            }

            public bool IsSetPutOrCall()
            {
                return IsSetField(Tags.PutOrCall);
            }
            public QuickFix.Fields.StrikePrice StrikePrice
            {
                get
                {
                    QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StrikePrice val)
            {
                this.StrikePrice = val;
            }

            public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StrikePrice val)
            {
                return IsSetStrikePrice();
            }

            public bool IsSetStrikePrice()
            {
                return IsSetField(Tags.StrikePrice);
            }
            public QuickFix.Fields.OptAttribute OptAttribute
            {
                get
                {
                    QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.OptAttribute val)
            {
                this.OptAttribute = val;
            }

            public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.OptAttribute val)
            {
                return IsSetOptAttribute();
            }

            public bool IsSetOptAttribute()
            {
                return IsSetField(Tags.OptAttribute);
            }
            public QuickFix.Fields.ContractMultiplier ContractMultiplier
            {
                get
                {
                    QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ContractMultiplier val)
            {
                this.ContractMultiplier = val;
            }

            public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ContractMultiplier val)
            {
                return IsSetContractMultiplier();
            }

            public bool IsSetContractMultiplier()
            {
                return IsSetField(Tags.ContractMultiplier);
            }
            public QuickFix.Fields.CouponRate CouponRate
            {
                get
                {
                    QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CouponRate val)
            {
                this.CouponRate = val;
            }

            public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CouponRate val)
            {
                return IsSetCouponRate();
            }

            public bool IsSetCouponRate()
            {
                return IsSetField(Tags.CouponRate);
            }
            public QuickFix.Fields.SecurityExchange SecurityExchange
            {
                get
                {
                    QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityExchange val)
            {
                this.SecurityExchange = val;
            }

            public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityExchange val)
            {
                return IsSetSecurityExchange();
            }

            public bool IsSetSecurityExchange()
            {
                return IsSetField(Tags.SecurityExchange);
            }
            public QuickFix.Fields.Issuer Issuer
            {
                get
                {
                    QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Issuer val)
            {
                this.Issuer = val;
            }

            public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Issuer val)
            {
                return IsSetIssuer();
            }

            public bool IsSetIssuer()
            {
                return IsSetField(Tags.Issuer);
            }
            public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
            {
                get
                {
                    QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedIssuerLen val)
            {
                this.EncodedIssuerLen = val;
            }

            public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedIssuerLen val)
            {
                return IsSetEncodedIssuerLen();
            }

            public bool IsSetEncodedIssuerLen()
            {
                return IsSetField(Tags.EncodedIssuerLen);
            }
            public QuickFix.Fields.EncodedIssuer EncodedIssuer
            {
                get
                {
                    QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedIssuer val)
            {
                this.EncodedIssuer = val;
            }

            public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedIssuer val)
            {
                return IsSetEncodedIssuer();
            }

            public bool IsSetEncodedIssuer()
            {
                return IsSetField(Tags.EncodedIssuer);
            }
            public QuickFix.Fields.SecurityDesc SecurityDesc
            {
                get
                {
                    QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityDesc val)
            {
                this.SecurityDesc = val;
            }

            public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityDesc val)
            {
                return IsSetSecurityDesc();
            }

            public bool IsSetSecurityDesc()
            {
                return IsSetField(Tags.SecurityDesc);
            }
            public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
            {
                get
                {
                    QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedSecurityDescLen val)
            {
                this.EncodedSecurityDescLen = val;
            }

            public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val)
            {
                return IsSetEncodedSecurityDescLen();
            }

            public bool IsSetEncodedSecurityDescLen()
            {
                return IsSetField(Tags.EncodedSecurityDescLen);
            }
            public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
            {
                get
                {
                    QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedSecurityDesc val)
            {
                this.EncodedSecurityDesc = val;
            }

            public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val)
            {
                return IsSetEncodedSecurityDesc();
            }

            public bool IsSetEncodedSecurityDesc()
            {
                return IsSetField(Tags.EncodedSecurityDesc);
            }
            public QuickFix.Fields.Currency Currency
            {
                get
                {
                    QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Currency val)
            {
                this.Currency = val;
            }

            public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Currency val)
            {
                return IsSetCurrency();
            }

            public bool IsSetCurrency()
            {
                return IsSetField(Tags.Currency);
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
        }
    }
}
