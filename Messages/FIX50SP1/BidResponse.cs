// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50SP1
    {
        public class BidResponse : Message
        {
            public const string MsgType = "l";

            public BidResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("l"));
            }


            public QuickFix.Fields.BidID BidID
            {
                get
                {
                    QuickFix.Fields.BidID val = new QuickFix.Fields.BidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.BidID val)
            {
                this.BidID = val;
            }

            public QuickFix.Fields.BidID Get(QuickFix.Fields.BidID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.BidID val)
            {
                return IsSetBidID();
            }

            public bool IsSetBidID()
            {
                return IsSetField(Tags.BidID);
            }
            public QuickFix.Fields.ClientBidID ClientBidID
            {
                get
                {
                    QuickFix.Fields.ClientBidID val = new QuickFix.Fields.ClientBidID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.ClientBidID val)
            {
                this.ClientBidID = val;
            }

            public QuickFix.Fields.ClientBidID Get(QuickFix.Fields.ClientBidID val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.ClientBidID val)
            {
                return IsSetClientBidID();
            }

            public bool IsSetClientBidID()
            {
                return IsSetField(Tags.ClientBidID);
            }
            public QuickFix.Fields.NoBidComponents NoBidComponents
            {
                get
                {
                    QuickFix.Fields.NoBidComponents val = new QuickFix.Fields.NoBidComponents();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }

            public void Set(QuickFix.Fields.NoBidComponents val)
            {
                this.NoBidComponents = val;
            }

            public QuickFix.Fields.NoBidComponents Get(QuickFix.Fields.NoBidComponents val)
            {
                GetField(val);
                return val;
            }

            public bool IsSet(QuickFix.Fields.NoBidComponents val)
            {
                return IsSetNoBidComponents();
            }

            public bool IsSetNoBidComponents()
            {
                return IsSetField(Tags.NoBidComponents);
            }
            public class NoBidComponentsGroup : Group
            {
                public static int[] fieldOrder = { Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.ListID, Tags.Country, Tags.Side, Tags.Price, Tags.PriceType, Tags.FairValue, Tags.NetGrossInd, Tags.SettlType, Tags.SettlDate, Tags.TradingSessionID, Tags.TradingSessionSubID, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0 };

                public NoBidComponentsGroup()
                  : base(Tags.NoBidComponents, Tags.Commission, fieldOrder)
                {
                }

                public override Group Clone()
                {
                    var clone = new NoBidComponentsGroup();
                    clone.CopyStateFrom(this);
                    return clone;
                }

                public QuickFix.Fields.Commission Commission
                {
                    get
                    {
                        QuickFix.Fields.Commission val = new QuickFix.Fields.Commission();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Commission val)
                {
                    this.Commission = val;
                }

                public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Commission val)
                {
                    return IsSetCommission();
                }

                public bool IsSetCommission()
                {
                    return IsSetField(Tags.Commission);
                }
                public QuickFix.Fields.CommType CommType
                {
                    get
                    {
                        QuickFix.Fields.CommType val = new QuickFix.Fields.CommType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CommType val)
                {
                    this.CommType = val;
                }

                public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CommType val)
                {
                    return IsSetCommType();
                }

                public bool IsSetCommType()
                {
                    return IsSetField(Tags.CommType);
                }
                public QuickFix.Fields.CommCurrency CommCurrency
                {
                    get
                    {
                        QuickFix.Fields.CommCurrency val = new QuickFix.Fields.CommCurrency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.CommCurrency val)
                {
                    this.CommCurrency = val;
                }

                public QuickFix.Fields.CommCurrency Get(QuickFix.Fields.CommCurrency val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.CommCurrency val)
                {
                    return IsSetCommCurrency();
                }

                public bool IsSetCommCurrency()
                {
                    return IsSetField(Tags.CommCurrency);
                }
                public QuickFix.Fields.FundRenewWaiv FundRenewWaiv
                {
                    get
                    {
                        QuickFix.Fields.FundRenewWaiv val = new QuickFix.Fields.FundRenewWaiv();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FundRenewWaiv val)
                {
                    this.FundRenewWaiv = val;
                }

                public QuickFix.Fields.FundRenewWaiv Get(QuickFix.Fields.FundRenewWaiv val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FundRenewWaiv val)
                {
                    return IsSetFundRenewWaiv();
                }

                public bool IsSetFundRenewWaiv()
                {
                    return IsSetField(Tags.FundRenewWaiv);
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
                public QuickFix.Fields.Country Country
                {
                    get
                    {
                        QuickFix.Fields.Country val = new QuickFix.Fields.Country();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Country val)
                {
                    this.Country = val;
                }

                public QuickFix.Fields.Country Get(QuickFix.Fields.Country val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Country val)
                {
                    return IsSetCountry();
                }

                public bool IsSetCountry()
                {
                    return IsSetField(Tags.Country);
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
                public QuickFix.Fields.Price Price
                {
                    get
                    {
                        QuickFix.Fields.Price val = new QuickFix.Fields.Price();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.Price val)
                {
                    this.Price = val;
                }

                public QuickFix.Fields.Price Get(QuickFix.Fields.Price val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.Price val)
                {
                    return IsSetPrice();
                }

                public bool IsSetPrice()
                {
                    return IsSetField(Tags.Price);
                }
                public QuickFix.Fields.PriceType PriceType
                {
                    get
                    {
                        QuickFix.Fields.PriceType val = new QuickFix.Fields.PriceType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.PriceType val)
                {
                    this.PriceType = val;
                }

                public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.PriceType val)
                {
                    return IsSetPriceType();
                }

                public bool IsSetPriceType()
                {
                    return IsSetField(Tags.PriceType);
                }
                public QuickFix.Fields.FairValue FairValue
                {
                    get
                    {
                        QuickFix.Fields.FairValue val = new QuickFix.Fields.FairValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.FairValue val)
                {
                    this.FairValue = val;
                }

                public QuickFix.Fields.FairValue Get(QuickFix.Fields.FairValue val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.FairValue val)
                {
                    return IsSetFairValue();
                }

                public bool IsSetFairValue()
                {
                    return IsSetField(Tags.FairValue);
                }
                public QuickFix.Fields.NetGrossInd NetGrossInd
                {
                    get
                    {
                        QuickFix.Fields.NetGrossInd val = new QuickFix.Fields.NetGrossInd();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.NetGrossInd val)
                {
                    this.NetGrossInd = val;
                }

                public QuickFix.Fields.NetGrossInd Get(QuickFix.Fields.NetGrossInd val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.NetGrossInd val)
                {
                    return IsSetNetGrossInd();
                }

                public bool IsSetNetGrossInd()
                {
                    return IsSetField(Tags.NetGrossInd);
                }
                public QuickFix.Fields.SettlType SettlType
                {
                    get
                    {
                        QuickFix.Fields.SettlType val = new QuickFix.Fields.SettlType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlType val)
                {
                    this.SettlType = val;
                }

                public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlType val)
                {
                    return IsSetSettlType();
                }

                public bool IsSetSettlType()
                {
                    return IsSetField(Tags.SettlType);
                }
                public QuickFix.Fields.SettlDate SettlDate
                {
                    get
                    {
                        QuickFix.Fields.SettlDate val = new QuickFix.Fields.SettlDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }

                public void Set(QuickFix.Fields.SettlDate val)
                {
                    this.SettlDate = val;
                }

                public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val)
                {
                    GetField(val);
                    return val;
                }

                public bool IsSet(QuickFix.Fields.SettlDate val)
                {
                    return IsSetSettlDate();
                }

                public bool IsSetSettlDate()
                {
                    return IsSetField(Tags.SettlDate);
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
}
