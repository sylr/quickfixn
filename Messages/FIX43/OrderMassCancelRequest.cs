// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX43
    {
        public class OrderMassCancelRequest : Message
        {
            public const string MsgType = "q";

            public OrderMassCancelRequest() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("q"));
            }

            public OrderMassCancelRequest(
                    QuickFix.Fields.ClOrdID aClOrdID,
                    QuickFix.Fields.MassCancelRequestType aMassCancelRequestType,
                    QuickFix.Fields.TransactTime aTransactTime
                ) : this()
            {
                this.ClOrdID = aClOrdID;
                this.MassCancelRequestType = aMassCancelRequestType;
                this.TransactTime = aTransactTime;
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
            public QuickFix.Fields.MassCancelRequestType MassCancelRequestType
            {
                get
                {
                    QuickFix.Fields.MassCancelRequestType val = new QuickFix.Fields.MassCancelRequestType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MassCancelRequestType val)
            {
                this.MassCancelRequestType = val;
            }

            public QuickFix.Fields.MassCancelRequestType Get(QuickFix.Fields.MassCancelRequestType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MassCancelRequestType val)
            {
                return IsSetMassCancelRequestType();
            }

            public bool IsSetMassCancelRequestType()
            {
                return IsSetField(Tags.MassCancelRequestType);
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
            public QuickFix.Fields.SecurityIDSource SecurityIDSource
            {
                get
                {
                    QuickFix.Fields.SecurityIDSource val = new QuickFix.Fields.SecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.SecurityIDSource val)
            {
                this.SecurityIDSource = val;
            }

            public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.SecurityIDSource val)
            {
                return IsSetSecurityIDSource();
            }

            public bool IsSetSecurityIDSource()
            {
                return IsSetField(Tags.SecurityIDSource);
            }
            public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
            {
                get
                {
                    QuickFix.Fields.NoSecurityAltID val = new QuickFix.Fields.NoSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoSecurityAltID val)
            {
                this.NoSecurityAltID = val;
            }

            public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoSecurityAltID val)
            {
                return IsSetNoSecurityAltID();
            }

            public bool IsSetNoSecurityAltID()
            {
                return IsSetField(Tags.NoSecurityAltID);
            }
            public QuickFix.Fields.Product Product
            {
                get
                {
                    QuickFix.Fields.Product val = new QuickFix.Fields.Product();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Product val)
            {
                this.Product = val;
            }

            public QuickFix.Fields.Product Get(QuickFix.Fields.Product val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Product val)
            {
                return IsSetProduct();
            }

            public bool IsSetProduct()
            {
                return IsSetField(Tags.Product);
            }
            public QuickFix.Fields.CFICode CFICode
            {
                get
                {
                    QuickFix.Fields.CFICode val = new QuickFix.Fields.CFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CFICode val)
            {
                this.CFICode = val;
            }

            public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CFICode val)
            {
                return IsSetCFICode();
            }

            public bool IsSetCFICode()
            {
                return IsSetField(Tags.CFICode);
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
            public QuickFix.Fields.MaturityDate MaturityDate
            {
                get
                {
                    QuickFix.Fields.MaturityDate val = new QuickFix.Fields.MaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.MaturityDate val)
            {
                this.MaturityDate = val;
            }

            public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.MaturityDate val)
            {
                return IsSetMaturityDate();
            }

            public bool IsSetMaturityDate()
            {
                return IsSetField(Tags.MaturityDate);
            }
            public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
            {
                get
                {
                    QuickFix.Fields.CouponPaymentDate val = new QuickFix.Fields.CouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CouponPaymentDate val)
            {
                this.CouponPaymentDate = val;
            }

            public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CouponPaymentDate val)
            {
                return IsSetCouponPaymentDate();
            }

            public bool IsSetCouponPaymentDate()
            {
                return IsSetField(Tags.CouponPaymentDate);
            }
            public QuickFix.Fields.IssueDate IssueDate
            {
                get
                {
                    QuickFix.Fields.IssueDate val = new QuickFix.Fields.IssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.IssueDate val)
            {
                this.IssueDate = val;
            }

            public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.IssueDate val)
            {
                return IsSetIssueDate();
            }

            public bool IsSetIssueDate()
            {
                return IsSetField(Tags.IssueDate);
            }
            public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
            {
                get
                {
                    QuickFix.Fields.RepoCollateralSecurityType val = new QuickFix.Fields.RepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RepoCollateralSecurityType val)
            {
                this.RepoCollateralSecurityType = val;
            }

            public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val)
            {
                return IsSetRepoCollateralSecurityType();
            }

            public bool IsSetRepoCollateralSecurityType()
            {
                return IsSetField(Tags.RepoCollateralSecurityType);
            }
            public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
            {
                get
                {
                    QuickFix.Fields.RepurchaseTerm val = new QuickFix.Fields.RepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RepurchaseTerm val)
            {
                this.RepurchaseTerm = val;
            }

            public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RepurchaseTerm val)
            {
                return IsSetRepurchaseTerm();
            }

            public bool IsSetRepurchaseTerm()
            {
                return IsSetField(Tags.RepurchaseTerm);
            }
            public QuickFix.Fields.RepurchaseRate RepurchaseRate
            {
                get
                {
                    QuickFix.Fields.RepurchaseRate val = new QuickFix.Fields.RepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RepurchaseRate val)
            {
                this.RepurchaseRate = val;
            }

            public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RepurchaseRate val)
            {
                return IsSetRepurchaseRate();
            }

            public bool IsSetRepurchaseRate()
            {
                return IsSetField(Tags.RepurchaseRate);
            }
            public QuickFix.Fields.Factor Factor
            {
                get
                {
                    QuickFix.Fields.Factor val = new QuickFix.Fields.Factor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Factor val)
            {
                this.Factor = val;
            }

            public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Factor val)
            {
                return IsSetFactor();
            }

            public bool IsSetFactor()
            {
                return IsSetField(Tags.Factor);
            }
            public QuickFix.Fields.CreditRating CreditRating
            {
                get
                {
                    QuickFix.Fields.CreditRating val = new QuickFix.Fields.CreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CreditRating val)
            {
                this.CreditRating = val;
            }

            public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CreditRating val)
            {
                return IsSetCreditRating();
            }

            public bool IsSetCreditRating()
            {
                return IsSetField(Tags.CreditRating);
            }
            public QuickFix.Fields.InstrRegistry InstrRegistry
            {
                get
                {
                    QuickFix.Fields.InstrRegistry val = new QuickFix.Fields.InstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.InstrRegistry val)
            {
                this.InstrRegistry = val;
            }

            public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.InstrRegistry val)
            {
                return IsSetInstrRegistry();
            }

            public bool IsSetInstrRegistry()
            {
                return IsSetField(Tags.InstrRegistry);
            }
            public QuickFix.Fields.CountryOfIssue CountryOfIssue
            {
                get
                {
                    QuickFix.Fields.CountryOfIssue val = new QuickFix.Fields.CountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.CountryOfIssue val)
            {
                this.CountryOfIssue = val;
            }

            public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.CountryOfIssue val)
            {
                return IsSetCountryOfIssue();
            }

            public bool IsSetCountryOfIssue()
            {
                return IsSetField(Tags.CountryOfIssue);
            }
            public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
            {
                get
                {
                    QuickFix.Fields.StateOrProvinceOfIssue val = new QuickFix.Fields.StateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.StateOrProvinceOfIssue val)
            {
                this.StateOrProvinceOfIssue = val;
            }

            public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val)
            {
                return IsSetStateOrProvinceOfIssue();
            }

            public bool IsSetStateOrProvinceOfIssue()
            {
                return IsSetField(Tags.StateOrProvinceOfIssue);
            }
            public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
            {
                get
                {
                    QuickFix.Fields.LocaleOfIssue val = new QuickFix.Fields.LocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.LocaleOfIssue val)
            {
                this.LocaleOfIssue = val;
            }

            public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.LocaleOfIssue val)
            {
                return IsSetLocaleOfIssue();
            }

            public bool IsSetLocaleOfIssue()
            {
                return IsSetField(Tags.LocaleOfIssue);
            }
            public QuickFix.Fields.RedemptionDate RedemptionDate
            {
                get
                {
                    QuickFix.Fields.RedemptionDate val = new QuickFix.Fields.RedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.RedemptionDate val)
            {
                this.RedemptionDate = val;
            }

            public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.RedemptionDate val)
            {
                return IsSetRedemptionDate();
            }

            public bool IsSetRedemptionDate()
            {
                return IsSetField(Tags.RedemptionDate);
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
            public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
            {
                get
                {
                    QuickFix.Fields.UnderlyingSymbol val = new QuickFix.Fields.UnderlyingSymbol();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSymbol val)
            {
                this.UnderlyingSymbol = val;
            }

            public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSymbol val)
            {
                return IsSetUnderlyingSymbol();
            }

            public bool IsSetUnderlyingSymbol()
            {
                return IsSetField(Tags.UnderlyingSymbol);
            }
            public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
            {
                get
                {
                    QuickFix.Fields.UnderlyingSymbolSfx val = new QuickFix.Fields.UnderlyingSymbolSfx();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSymbolSfx val)
            {
                this.UnderlyingSymbolSfx = val;
            }

            public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val)
            {
                return IsSetUnderlyingSymbolSfx();
            }

            public bool IsSetUnderlyingSymbolSfx()
            {
                return IsSetField(Tags.UnderlyingSymbolSfx);
            }
            public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
            {
                get
                {
                    QuickFix.Fields.UnderlyingSecurityID val = new QuickFix.Fields.UnderlyingSecurityID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSecurityID val)
            {
                this.UnderlyingSecurityID = val;
            }

            public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val)
            {
                return IsSetUnderlyingSecurityID();
            }

            public bool IsSetUnderlyingSecurityID()
            {
                return IsSetField(Tags.UnderlyingSecurityID);
            }
            public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
            {
                get
                {
                    QuickFix.Fields.UnderlyingSecurityIDSource val = new QuickFix.Fields.UnderlyingSecurityIDSource();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val)
            {
                this.UnderlyingSecurityIDSource = val;
            }

            public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val)
            {
                return IsSetUnderlyingSecurityIDSource();
            }

            public bool IsSetUnderlyingSecurityIDSource()
            {
                return IsSetField(Tags.UnderlyingSecurityIDSource);
            }
            public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
            {
                get
                {
                    QuickFix.Fields.NoUnderlyingSecurityAltID val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val)
            {
                this.NoUnderlyingSecurityAltID = val;
            }

            public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val)
            {
                return IsSetNoUnderlyingSecurityAltID();
            }

            public bool IsSetNoUnderlyingSecurityAltID()
            {
                return IsSetField(Tags.NoUnderlyingSecurityAltID);
            }
            public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
            {
                get
                {
                    QuickFix.Fields.UnderlyingProduct val = new QuickFix.Fields.UnderlyingProduct();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingProduct val)
            {
                this.UnderlyingProduct = val;
            }

            public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingProduct val)
            {
                return IsSetUnderlyingProduct();
            }

            public bool IsSetUnderlyingProduct()
            {
                return IsSetField(Tags.UnderlyingProduct);
            }
            public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
            {
                get
                {
                    QuickFix.Fields.UnderlyingCFICode val = new QuickFix.Fields.UnderlyingCFICode();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingCFICode val)
            {
                this.UnderlyingCFICode = val;
            }

            public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingCFICode val)
            {
                return IsSetUnderlyingCFICode();
            }

            public bool IsSetUnderlyingCFICode()
            {
                return IsSetField(Tags.UnderlyingCFICode);
            }
            public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
            {
                get
                {
                    QuickFix.Fields.UnderlyingSecurityType val = new QuickFix.Fields.UnderlyingSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSecurityType val)
            {
                this.UnderlyingSecurityType = val;
            }

            public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val)
            {
                return IsSetUnderlyingSecurityType();
            }

            public bool IsSetUnderlyingSecurityType()
            {
                return IsSetField(Tags.UnderlyingSecurityType);
            }
            public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
            {
                get
                {
                    QuickFix.Fields.UnderlyingMaturityMonthYear val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val)
            {
                this.UnderlyingMaturityMonthYear = val;
            }

            public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val)
            {
                return IsSetUnderlyingMaturityMonthYear();
            }

            public bool IsSetUnderlyingMaturityMonthYear()
            {
                return IsSetField(Tags.UnderlyingMaturityMonthYear);
            }
            public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
            {
                get
                {
                    QuickFix.Fields.UnderlyingMaturityDate val = new QuickFix.Fields.UnderlyingMaturityDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingMaturityDate val)
            {
                this.UnderlyingMaturityDate = val;
            }

            public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val)
            {
                return IsSetUnderlyingMaturityDate();
            }

            public bool IsSetUnderlyingMaturityDate()
            {
                return IsSetField(Tags.UnderlyingMaturityDate);
            }
            public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
            {
                get
                {
                    QuickFix.Fields.UnderlyingCouponPaymentDate val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val)
            {
                this.UnderlyingCouponPaymentDate = val;
            }

            public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val)
            {
                return IsSetUnderlyingCouponPaymentDate();
            }

            public bool IsSetUnderlyingCouponPaymentDate()
            {
                return IsSetField(Tags.UnderlyingCouponPaymentDate);
            }
            public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
            {
                get
                {
                    QuickFix.Fields.UnderlyingIssueDate val = new QuickFix.Fields.UnderlyingIssueDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingIssueDate val)
            {
                this.UnderlyingIssueDate = val;
            }

            public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val)
            {
                return IsSetUnderlyingIssueDate();
            }

            public bool IsSetUnderlyingIssueDate()
            {
                return IsSetField(Tags.UnderlyingIssueDate);
            }
            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
            {
                get
                {
                    QuickFix.Fields.UnderlyingRepoCollateralSecurityType val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
            {
                this.UnderlyingRepoCollateralSecurityType = val;
            }

            public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
            {
                return IsSetUnderlyingRepoCollateralSecurityType();
            }

            public bool IsSetUnderlyingRepoCollateralSecurityType()
            {
                return IsSetField(Tags.UnderlyingRepoCollateralSecurityType);
            }
            public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
            {
                get
                {
                    QuickFix.Fields.UnderlyingRepurchaseTerm val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val)
            {
                this.UnderlyingRepurchaseTerm = val;
            }

            public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val)
            {
                return IsSetUnderlyingRepurchaseTerm();
            }

            public bool IsSetUnderlyingRepurchaseTerm()
            {
                return IsSetField(Tags.UnderlyingRepurchaseTerm);
            }
            public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
            {
                get
                {
                    QuickFix.Fields.UnderlyingRepurchaseRate val = new QuickFix.Fields.UnderlyingRepurchaseRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val)
            {
                this.UnderlyingRepurchaseRate = val;
            }

            public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val)
            {
                return IsSetUnderlyingRepurchaseRate();
            }

            public bool IsSetUnderlyingRepurchaseRate()
            {
                return IsSetField(Tags.UnderlyingRepurchaseRate);
            }
            public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
            {
                get
                {
                    QuickFix.Fields.UnderlyingFactor val = new QuickFix.Fields.UnderlyingFactor();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingFactor val)
            {
                this.UnderlyingFactor = val;
            }

            public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingFactor val)
            {
                return IsSetUnderlyingFactor();
            }

            public bool IsSetUnderlyingFactor()
            {
                return IsSetField(Tags.UnderlyingFactor);
            }
            public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
            {
                get
                {
                    QuickFix.Fields.UnderlyingCreditRating val = new QuickFix.Fields.UnderlyingCreditRating();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingCreditRating val)
            {
                this.UnderlyingCreditRating = val;
            }

            public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val)
            {
                return IsSetUnderlyingCreditRating();
            }

            public bool IsSetUnderlyingCreditRating()
            {
                return IsSetField(Tags.UnderlyingCreditRating);
            }
            public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
            {
                get
                {
                    QuickFix.Fields.UnderlyingInstrRegistry val = new QuickFix.Fields.UnderlyingInstrRegistry();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingInstrRegistry val)
            {
                this.UnderlyingInstrRegistry = val;
            }

            public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val)
            {
                return IsSetUnderlyingInstrRegistry();
            }

            public bool IsSetUnderlyingInstrRegistry()
            {
                return IsSetField(Tags.UnderlyingInstrRegistry);
            }
            public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
            {
                get
                {
                    QuickFix.Fields.UnderlyingCountryOfIssue val = new QuickFix.Fields.UnderlyingCountryOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val)
            {
                this.UnderlyingCountryOfIssue = val;
            }

            public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val)
            {
                return IsSetUnderlyingCountryOfIssue();
            }

            public bool IsSetUnderlyingCountryOfIssue()
            {
                return IsSetField(Tags.UnderlyingCountryOfIssue);
            }
            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
            {
                get
                {
                    QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
            {
                this.UnderlyingStateOrProvinceOfIssue = val;
            }

            public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
            {
                return IsSetUnderlyingStateOrProvinceOfIssue();
            }

            public bool IsSetUnderlyingStateOrProvinceOfIssue()
            {
                return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue);
            }
            public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
            {
                get
                {
                    QuickFix.Fields.UnderlyingLocaleOfIssue val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val)
            {
                this.UnderlyingLocaleOfIssue = val;
            }

            public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val)
            {
                return IsSetUnderlyingLocaleOfIssue();
            }

            public bool IsSetUnderlyingLocaleOfIssue()
            {
                return IsSetField(Tags.UnderlyingLocaleOfIssue);
            }
            public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
            {
                get
                {
                    QuickFix.Fields.UnderlyingRedemptionDate val = new QuickFix.Fields.UnderlyingRedemptionDate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingRedemptionDate val)
            {
                this.UnderlyingRedemptionDate = val;
            }

            public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val)
            {
                return IsSetUnderlyingRedemptionDate();
            }

            public bool IsSetUnderlyingRedemptionDate()
            {
                return IsSetField(Tags.UnderlyingRedemptionDate);
            }
            public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
            {
                get
                {
                    QuickFix.Fields.UnderlyingPutOrCall val = new QuickFix.Fields.UnderlyingPutOrCall();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingPutOrCall val)
            {
                this.UnderlyingPutOrCall = val;
            }

            public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val)
            {
                return IsSetUnderlyingPutOrCall();
            }

            public bool IsSetUnderlyingPutOrCall()
            {
                return IsSetField(Tags.UnderlyingPutOrCall);
            }
            public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
            {
                get
                {
                    QuickFix.Fields.UnderlyingStrikePrice val = new QuickFix.Fields.UnderlyingStrikePrice();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingStrikePrice val)
            {
                this.UnderlyingStrikePrice = val;
            }

            public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val)
            {
                return IsSetUnderlyingStrikePrice();
            }

            public bool IsSetUnderlyingStrikePrice()
            {
                return IsSetField(Tags.UnderlyingStrikePrice);
            }
            public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
            {
                get
                {
                    QuickFix.Fields.UnderlyingOptAttribute val = new QuickFix.Fields.UnderlyingOptAttribute();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingOptAttribute val)
            {
                this.UnderlyingOptAttribute = val;
            }

            public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val)
            {
                return IsSetUnderlyingOptAttribute();
            }

            public bool IsSetUnderlyingOptAttribute()
            {
                return IsSetField(Tags.UnderlyingOptAttribute);
            }
            public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
            {
                get
                {
                    QuickFix.Fields.UnderlyingContractMultiplier val = new QuickFix.Fields.UnderlyingContractMultiplier();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingContractMultiplier val)
            {
                this.UnderlyingContractMultiplier = val;
            }

            public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val)
            {
                return IsSetUnderlyingContractMultiplier();
            }

            public bool IsSetUnderlyingContractMultiplier()
            {
                return IsSetField(Tags.UnderlyingContractMultiplier);
            }
            public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
            {
                get
                {
                    QuickFix.Fields.UnderlyingCouponRate val = new QuickFix.Fields.UnderlyingCouponRate();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingCouponRate val)
            {
                this.UnderlyingCouponRate = val;
            }

            public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val)
            {
                return IsSetUnderlyingCouponRate();
            }

            public bool IsSetUnderlyingCouponRate()
            {
                return IsSetField(Tags.UnderlyingCouponRate);
            }
            public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
            {
                get
                {
                    QuickFix.Fields.UnderlyingSecurityExchange val = new QuickFix.Fields.UnderlyingSecurityExchange();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSecurityExchange val)
            {
                this.UnderlyingSecurityExchange = val;
            }

            public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val)
            {
                return IsSetUnderlyingSecurityExchange();
            }

            public bool IsSetUnderlyingSecurityExchange()
            {
                return IsSetField(Tags.UnderlyingSecurityExchange);
            }
            public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
            {
                get
                {
                    QuickFix.Fields.UnderlyingIssuer val = new QuickFix.Fields.UnderlyingIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingIssuer val)
            {
                this.UnderlyingIssuer = val;
            }

            public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingIssuer val)
            {
                return IsSetUnderlyingIssuer();
            }

            public bool IsSetUnderlyingIssuer()
            {
                return IsSetField(Tags.UnderlyingIssuer);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
            {
                get
                {
                    QuickFix.Fields.EncodedUnderlyingIssuerLen val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
            {
                this.EncodedUnderlyingIssuerLen = val;
            }

            public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
            {
                return IsSetEncodedUnderlyingIssuerLen();
            }

            public bool IsSetEncodedUnderlyingIssuerLen()
            {
                return IsSetField(Tags.EncodedUnderlyingIssuerLen);
            }
            public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
            {
                get
                {
                    QuickFix.Fields.EncodedUnderlyingIssuer val = new QuickFix.Fields.EncodedUnderlyingIssuer();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val)
            {
                this.EncodedUnderlyingIssuer = val;
            }

            public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val)
            {
                return IsSetEncodedUnderlyingIssuer();
            }

            public bool IsSetEncodedUnderlyingIssuer()
            {
                return IsSetField(Tags.EncodedUnderlyingIssuer);
            }
            public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
            {
                get
                {
                    QuickFix.Fields.UnderlyingSecurityDesc val = new QuickFix.Fields.UnderlyingSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.UnderlyingSecurityDesc val)
            {
                this.UnderlyingSecurityDesc = val;
            }

            public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val)
            {
                return IsSetUnderlyingSecurityDesc();
            }

            public bool IsSetUnderlyingSecurityDesc()
            {
                return IsSetField(Tags.UnderlyingSecurityDesc);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
            {
                get
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDescLen val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
            {
                this.EncodedUnderlyingSecurityDescLen = val;
            }

            public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
            {
                return IsSetEncodedUnderlyingSecurityDescLen();
            }

            public bool IsSetEncodedUnderlyingSecurityDescLen()
            {
                return IsSetField(Tags.EncodedUnderlyingSecurityDescLen);
            }
            public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
            {
                get
                {
                    QuickFix.Fields.EncodedUnderlyingSecurityDesc val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
            {
                this.EncodedUnderlyingSecurityDesc = val;
            }

            public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
            {
                return IsSetEncodedUnderlyingSecurityDesc();
            }

            public bool IsSetEncodedUnderlyingSecurityDesc()
            {
                return IsSetField(Tags.EncodedUnderlyingSecurityDesc);
            }
            public QuickFix.Fields.Side Side
            {
                get
                {
                    QuickFix.Fields.Side val = new QuickFix.Fields.Side();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.Side val)
            {
                this.Side = val;
            }

            public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.Side val)
            {
                return IsSetSide();
            }

            public bool IsSetSide()
            {
                return IsSetField(Tags.Side);
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
            public class NoSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = { Tags.SecurityAltID, Tags.SecurityAltIDSource, 0 };

                public NoSecurityAltIDGroup()
                  : base(Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.SecurityAltID SecurityAltID
                {
                    get
                    {
                        QuickFix.Fields.SecurityAltID val = new QuickFix.Fields.SecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityAltID val)
                {
                    this.SecurityAltID = val;
                }

                public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityAltID val)
                {
                    return IsSetSecurityAltID();
                }

                public bool IsSetSecurityAltID()
                {
                    return IsSetField(Tags.SecurityAltID);
                }
                public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
                {
                    get
                    {
                        QuickFix.Fields.SecurityAltIDSource val = new QuickFix.Fields.SecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SecurityAltIDSource val)
                {
                    this.SecurityAltIDSource = val;
                }

                public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SecurityAltIDSource val)
                {
                    return IsSetSecurityAltIDSource();
                }

                public bool IsSetSecurityAltIDSource()
                {
                    return IsSetField(Tags.SecurityAltIDSource);
                }

            }
            public class NoUnderlyingSecurityAltIDGroup : Group
            {
                public static int[] fieldOrder = { Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0 };

                public NoUnderlyingSecurityAltIDGroup()
                  : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoUnderlyingSecurityAltIDGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityAltID val = new QuickFix.Fields.UnderlyingSecurityAltID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityAltID val)
                {
                    this.UnderlyingSecurityAltID = val;
                }

                public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val)
                {
                    return IsSetUnderlyingSecurityAltID();
                }

                public bool IsSetUnderlyingSecurityAltID()
                {
                    return IsSetField(Tags.UnderlyingSecurityAltID);
                }
                public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
                {
                    get
                    {
                        QuickFix.Fields.UnderlyingSecurityAltIDSource val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
                {
                    this.UnderlyingSecurityAltIDSource = val;
                }

                public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
                {
                    return IsSetUnderlyingSecurityAltIDSource();
                }

                public bool IsSetUnderlyingSecurityAltIDSource()
                {
                    return IsSetField(Tags.UnderlyingSecurityAltIDSource);
                }

            }
        }
    }
}
