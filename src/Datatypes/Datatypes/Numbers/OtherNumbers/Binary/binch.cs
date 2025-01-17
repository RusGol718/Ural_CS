namespace Datatypes.Numbers.OtherNumbers.Binary;

public interface Interface_UBinch
{
}

public class binch : VOID, Interface_UBinch, Interface_Ural_Datatype
{
    public static readonly string Reference = "Б#";
    public static readonly string DefaultValue = Reference + "0";
    public const int MaxLength = 64;

    public binch(string _value) : base(_value)
    {
        this.value = Slice(_value, 0, 2) == "Б#" ? _value : Reference + _value;
    }

    public binch(ushort _value) : base(_value)
    {
        this.value = Reference + this.NatchToBinch(_value);
    }

    public binch(uint _value) : base(_value)
    {
        this.value = Reference + this.NatchToBinch(_value);
    }

    public binch(ulong _value) : base(_value)
    {
        this.value = Reference + this.NatchToBinch(_value);
    }

    public binch(short _value) : base(_value)
    {
        this.value = _value switch
        {
            >= 0 => Reference + this.NatchToBinch(_value),
            _ => Reference + this.OtricCelchToBinch(_value)
        };
    }

    public binch(int _value) : base(_value)
    {
        this.value = _value switch
        {
            >= 0 => Reference + this.NatchToBinch(_value),
            _ => Reference + this.OtricCelchToBinch(_value)
        };
    }

    public binch(long _value) : base(_value)
    {
        this.value = _value switch
        {
            >= 0 => Reference + this.NatchToBinch(_value),
            _ => Reference + this.OtricCelchToBinch(_value)
        };
    }

    /*
    public binch(string _value) : base(_value)
    {

        if ((Slice(_value, 0, 2) == binch.Reference) & (BinchCheck(_value).value == "ИСТИНА"))
        {
            this.value = _value;
        }
        else if ((Slice(_value, 0, 2) != binch.Reference) & (BinchCheck(binch.Reference + _value).value == "ИСТИНА"))
        {
            this.value = binch.Reference + _value;
        }
        else
        {
            SyntaxInvalidBinchDatatypeError er = new SyntaxInvalidBinchDatatypeError(0, 0);
            this.value = binch.DefaultValue;
        }

        if (Slice(_value, 0, 2).Length > shesch.MaxLength)
        {
            //ошибка;
            this.value = vosch.DefaultValue;
        }

    }
    */
    /*
    public binch(ushort _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = NatchToBinch(_value);
    }

    public binch(uint _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = NatchToBinch(_value);
    }

    public binch(ulong _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = NatchToBinch(_value);
    }

    public binch(int _value) : base(_value)
    {
        if (_value >= 0)
        {
            this.subvalue = "+";
            this.value = NatchToBinch(_value);
        }
        else
        {
            this.subvalue = "-";
            this.value = OneArbs(OtricCelchToBinch(_value));
        }
    }

    public binch(short _value) : base(_value)
    {
        int dec = Convert.ToInt32(_value);
        if (dec > 0)
        {
            this.subvalue = "+";
            this.value = NatchToBinch(dec);
        }
        else
        {
            this.subvalue = "-";
            this.value = OneArbs(OtricCelchToBinch(dec));
        }
    }

    public binch(long _value) : base(_value)
    {
        long dec = Convert.ToInt64(_value);
        if (dec > 0)
        {
            this.subvalue = "+";
            this.value = NatchToBinch(dec);;
        }
        else
        {
            this.subvalue = "-";
            this.value = OneArbs(OtricCelchToBinch(dec));
        }
    }

    public binch(ushort _value, string _subvalue) : base(_value, _subvalue)
    {
        this.subvalue = "+";
        this.value = NatchToBinch(_value);
    }

    public binch(uint _value, string _subvalue) : base(_value, _subvalue)
    {
        this.subvalue = "+";
        this.value = NatchToBinch(_value);
    }

    public binch(ulong _value, string _subvalue) : base(_value, _subvalue)
    {
        this.subvalue = "+";
        this.value = NatchToBinch(_value);
    }
    */
    protected static RCI BinchCheck(string bin)
    {
        RCI flag = new RCI(true);
        if (Slice(bin, 0, 2) == Reference)
        {
            for (int i = 2; i < bin.Length; i++)
                switch ((bin[i] == '0') | (bin[i] == '1'))
                {
                    case true :
                    {
                        flag = RCI.I(flag, flag);
                        switch (i)
                        {
                            case <= MaxLength + 1 :
                                continue;
                            default :
                                flag = new RCI(false);
                                flag = RCI.I(flag, flag);
                                break;
                        }

                        break;
                    }
                    default :
                        flag = new RCI(false);
                        flag = RCI.I(flag, flag);
                        break;
                }

            return flag;
        }

        flag = new RCI(false);
        return flag;
    }

    protected static RCI BinchCheck(binch bin)
    {
        RCI flag = new RCI(true);
        if (Slice(bin.value, 0, 2) == Reference)
        {
            for (int i = 2; i < bin.value.Length; i++)
                if ((bin.value[i] == '0') | (bin.value[i] == '1'))
                {
                    flag = RCI.I(flag, flag);
                    switch (i)
                    {
                        case <= MaxLength + 1 :
                            continue;
                        default :
                            flag = new RCI(false);
                            flag = RCI.I(flag, flag);
                            break;
                    }
                }
                else
                {
                    flag = new RCI(false);
                    flag = RCI.I(flag, flag);
                }

            return flag;
        }

        flag = new RCI(false);
        return flag;
    }

    protected static RCI MantissaCheck(string bin)
    {
        RCI flag = new RCI(true);
        if ((Slice(bin, 0, 2) == Reference) & ((bin[2] == '0') | (bin[2] == '1')) & (bin[3] == '.'))
        {
            for (int i = 4; i < bin.Length; i++)
                switch ((bin[i] == '0') | (bin[i] == '1'))
                {
                    case true :
                        flag = RCI.I(flag, flag);
                        break;
                    default :
                        flag = new RCI(false);
                        flag = RCI.I(flag, flag);
                        break;
                }
        }
        else
        {
            flag = new RCI(false);
        }

        return flag;
    }
    /*
    public dynamic BinchToNatch()
    {
        double dec = 0D;
        string bin_str = Convert.ToString(this.value);
        if (binch.BinchCheck(bin_str).value == "ИСТИНА")
        {
            bin_str = Slice(bin_str, 2);
            bin_str = binch.Reverse(bin_str);
            for (int i = 0; i < bin_str.Length; i++)
            {
                if (bin_str[i] == '1')
                {
                    dec += pow(2D, (double)i);
                }
            }
            if (this.subvalue == "-")
            {
                return dec*(-1);
            }
            else
            {
                return dec;
            }
        }
        else
        {
            SyntaxInvalidBinchDatatypeError er = new SyntaxInvalidBinchDatatypeError(0, 0);
            return er;
        }
    }

    public static dynamic BinchToDrobch(string mantissa, string exponent)
    {
        double dec_mantissa = 0;
        double dec_exponent = 0;
        double sign = 0;
        string real_mantissa = "";
        string real_exponent = "";
        if ((MantissaCheck(mantissa).value == "ИСТИНА") & (BinchCheck(exponent).value == "ИСТИНА"))
        {
            if (mantissa[2] == '1')
            {
                sign = -1;
            }
            else
            {
                sign = 1;
            }

            real_mantissa = VOID.Slice(mantissa, 4);
            for (int i = 0; i < real_mantissa.Length; i++)
            {
                if (real_mantissa[i] == '1')
                {
                    dec_mantissa += (Math.Pow(2D, -i-1));
                }
            }

            real_exponent = VOID.Slice(exponent, 2);
            real_exponent = VOID.Reverse(exponent);
            for (int i = 0; i < real_exponent.Length; i++)
            {
                if (real_exponent[i] == '1')
                {
                    dec_exponent += Math.Pow(2D, (double)i);
                }
            }

            return ((dec_mantissa*sign)*Math.Pow(2D, dec_exponent));
        }
        else
        {
            SyntaxInvalidBinchDatatypeError er = new SyntaxInvalidBinchDatatypeError(0, 0);
            return er;
        }
    }

    protected static string ReverseNumbers(string _value)
    {
        string result = "";
        string val_nobx = "";
        if (Slice(_value, 2) == binch.Reference)
        {
            val_nobx = Slice(_value, 2);
        }
        else
        {
            val_nobx = _value;
        }
        for (int i = 0; i < val_nobx.Length; i++)
        {
            if (val_nobx[i] == '0')
            {
                result += "1";
            }
            else
            {
                result += "0";
            }
        }
        return binch.Reference + result;
    }

    public dynamic BinchToOtricCelch()
    {
        string bin = Slice(Convert.ToString(this.value), 3);
        int len = bin.Length;
        string ones = "";

        for (int i = 0; i < bin.Length; i++)
        {
            ones += "1";
        }
        bin = (new binch(bin).add(new binch(ones))).value;
        bin = binch.Reference + Slice(bin, bin.Length - len - 2);
        bin = ReverseNumbers(bin);
        return (-1)*(new binch(bin).BinchToNatch());
    }

    protected static dynamic OtricCelchToBinch(short num)
    {
        int dec = Convert.ToInt32(num);
        dec = dec*(-1);
        string result = "";
        while (dec > 0)
        {
            result = Convert.ToString(dec%2) + result;
            dec = dec/2;
        }
        result = ZeroArbs(result);
        result = ReverseNumbers(result);
        binch bin = new binch(result);
        bin = bin.add(new binch(binch.Reference + "1"));
        result = Slice(bin.value, 2);
        return binch.Reference + result;
    }

    protected static dynamic OtricCelchToBinch(int num)
    {
        int dec = num*(-1);
        string result = "";
        while (dec > 0)
        {
            result = Convert.ToString(dec%2) + result;
            dec = dec/2;
        }
        result = ZeroArbs(result);
        result = ReverseNumbers(result);
        binch bin = new binch(result);
        bin = bin.add(new binch(binch.Reference + "1"));
        result = Slice(bin.value, 2);
        return binch.Reference + result;
    }

    protected static dynamic OtricCelchToBinch(long num)
    {
        long dec = Convert.ToInt64(num);
        dec = dec*(-1);
        string result = "";
        while (dec > 0)
        {
            result = Convert.ToString(dec%2) + result;
            dec = dec/2;
        }
        result = ZeroArbs(result);
        result = ReverseNumbers(result);
        binch bin = new binch(result);
        bin = bin.add(new binch(binch.Reference + "1"));
        result = Slice(bin.value, 2);
        return binch.Reference + result;
    }

    public dynamic NatchToBinch(ushort _value)
    {
        int dec = Convert.ToInt32(_value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(uint _value)
    {
        int dec = Convert.ToInt32(_value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(ulong _value)
    {
        ulong dec = Convert.ToUInt64(_value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(natch16 _value)
    {
        int dec = Convert.ToInt32(_value.value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(natch32 _value)
    {
        int dec = Convert.ToInt32(_value.value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(natch64 _value)
    {
        long dec = Convert.ToInt64(_value.value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }



    public dynamic NatchToBinch(short _value)
    {
        int dec = Convert.ToInt32(_value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(int _value)
    {
        int dec = _value;

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic NatchToBinch(long _value)
    {
        long dec = Convert.ToInt64(_value);

        string result = "";
        if (dec == 0)
        {
            return binch.Reference + "0";
        }
        else if (dec == 1)
        {
            return binch.Reference + "1";
        }
        else
        {
            while (dec > 0)
            {
                result = Convert.ToString(dec%2) + result;
                dec = dec/2;
            }
            return (binch.Reference + result);
        }
    }

    public dynamic CelchToBinch(short _value)
    {
        if (_value > 0)
        {
            return new binch(NatchToBinch(_value));
        }
        else
        {
            return OtricCelchToBinch(_value);
        }

    }

    public dynamic CelchToBinch(int _value)
    {
        if (_value > 0)
        {
            return new binch(NatchToBinch(_value));
        }
        else
        {
            return OtricCelchToBinch(_value);
        }

    }
    protected static string ZeroArbs(string str)
    {
        int nulls = binch.MaxLength - str.Length;
        for (int i = 0; i < nulls; i++)
        {
            str = "0" + str;
        }
        return str;
    }

    protected static string OneArbs(string str)
    {
        int ones = binch.MaxLength - str.Length;
        for (int i = 0; i < ones; i++)
        {
            str = "1" + str;
        }
        return str;
    }

    protected static string ZeroRemove(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '1')
            {
                str = Slice(str, i);
                break;
            }
        }
        return str;
    }

    */

    protected static string ZeroArbs(string _value)
    {
        int len = MaxLength - _value.Length + 1;
        for (int i = 0; i < len; i++) _value = "0" + _value;

        return _value;
    }

    protected static string Inverse(string _value)
    {
        string result = "";
        for (int i = 0; i < _value.Length; i++)
            result += _value[i] switch
            {
                '0' => "1",
                _ => "0"
            };

        return result;
    }

    public dynamic NatchToBinch(ushort _value)
    {
        string result = "";
        switch (_value)
        {
            case 0 :
                return ZeroArbs("0");
            case 1 :
                return ZeroArbs("1");
            default :
            {
                while (_value > 0)
                {
                    result = Convert.ToString(_value % 2) + result;
                    _value = (ushort)(_value / 2);
                }

                return ZeroArbs(result);
            }
        }
    }

    public dynamic NatchToBinch(uint _value)
    {
        string result = "";
        switch (_value)
        {
            case 0 :
                return ZeroArbs("0");
            case 1 :
                return ZeroArbs("1");
            default :
            {
                while (_value > 0)
                {
                    result = Convert.ToString(_value % 2) + result;
                    _value = _value / 2;
                }

                return ZeroArbs(result);
            }
        }
    }

    public dynamic NatchToBinch(ulong _value)
    {
        string result = "";
        switch (_value)
        {
            case 0 :
                return ZeroArbs("0");
            case 1 :
                return ZeroArbs("1");
            default :
            {
                while (_value > 0)
                {
                    result = Convert.ToString(_value % 2) + result;
                    _value = _value / 2;
                }

                return ZeroArbs(result);
            }
        }
    }

    public dynamic NatchToBinch(short _value)
    {
        string result = "";
        switch (_value)
        {
            case 0 :
                return ZeroArbs("0");
            case 1 :
                return ZeroArbs("1");
            default :
            {
                while (_value > 0)
                {
                    result = Convert.ToString(_value % 2) + result;
                    _value = (short)(_value / 2);
                }

                return ZeroArbs(result);
            }
        }
    }

    public dynamic NatchToBinch(int _value)
    {
        string result = "";
        switch (_value)
        {
            case 0 :
                return ZeroArbs("0");
            case 1 :
                return ZeroArbs("1");
            default :
            {
                while (_value > 0)
                {
                    result = Convert.ToString(_value % 2) + result;
                    _value = _value / 2;
                }

                return ZeroArbs(result);
            }
        }
    }

    public dynamic NatchToBinch(long _value)
    {
        string result = "";
        switch (_value)
        {
            case 0 :
                return Reference + ZeroArbs("0");
            case 1 :
                return Reference + ZeroArbs("1");
            default :
            {
                while (_value > 0)
                {
                    result = Convert.ToString(_value % 2) + result;
                    _value = _value / 2;
                }

                return ZeroArbs(result);
            }
        }
    }

    public dynamic OtricCelchToBinch(short _value)
    {
        string bin = this.NatchToBinch(-_value);
        bin = Inverse(bin);
        bin = Add(bin, this.NatchToBinch(1));
        return bin;
    }

    public dynamic OtricCelchToBinch(int _value)
    {
        string bin = this.NatchToBinch(-_value);
        bin = Inverse(bin);
        bin = Add(bin, this.NatchToBinch(1));
        return bin;
    }

    public dynamic OtricCelchToBinch(long _value)
    {
        string bin = this.NatchToBinch(-_value);
        bin = Inverse(bin);
        bin = Add(bin, this.NatchToBinch(1));
        return bin;
    }

    protected static string Add(string num1, string num2)
    {
        int res = '0';
        string sum = "";

        if (Slice(num1, 0, 2) == "Б#")
        {
            num1 = Slice(num1, 2);
        }

        if (Slice(num1, 0, 2) == "Б#")
        {
            num1 = Slice(num2, 2);
        }

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int value = num1[i] - '0' + (num2[i] - '0') + (res - '0');
            switch (value)
            {
                case 0 :
                    sum = "0" + sum;
                    res = '0';
                    break;
                case 1 :
                    sum = "1" + sum;
                    res = '0';
                    break;
                case 2 :
                    sum = "0" + sum;
                    res = '1';
                    break;
                default :
                    sum = "1" + sum;
                    res = '1';
                    break;
            }
        }

        sum = sum.Length switch
        {
            MaxLength + 2 => Slice(sum, 1),
            _ => sum
        };

        return sum;
    }

    public static binch ___Add(binch num1, binch num2)
    {
        string bin1 = Convert.ToString(num1.value);
        bin1 = Slice(bin1, 2);
        string bin2 = Convert.ToString(num2.value);
        bin2 = Slice(bin2, 2);
        return new binch(Add(bin1, bin2));
    }

    public static binch ___Add(binch num1, string num2)
    {
        string bin1 = Convert.ToString(num1.value);
        string bin2;
        bin1 = Slice(bin1, 2);
        bin2 = Slice(num2, 2);
        return new binch(Add(bin1, bin2));
    }

    public static binch ___Add(string num1, binch num2)
    {
        string bin2 = Convert.ToString(num2.value);
        string bin1;
        bin1 = Slice(num1, 2);
        bin2 = Slice(bin2, 2);
        return new binch(Add(bin1, bin2));
    }

    public static binch ___Add(string num1, string num2)
    {
        string bin1;
        string bin2;
        bin1 = Slice(num1, 2);
        bin2 = Slice(num2, 2);
        return new binch(Add(bin1, bin2));
    }

    public static string Lsh(string bin, int ls)
    {
        for (int i = 0; i < ls; i++) bin = bin + "0";

        bin = bin.Length switch
        {
            > MaxLength => Slice(bin, bin.Length - MaxLength),
            _ => bin
        };

        switch (bin.Length)
        {
            case < MaxLength :
            {
                for (int i = 0; i < MaxLength; i++)
                {
                    bin = "0" + bin;
                    if (bin.Length == MaxLength)
                    {
                        break;
                    }
                }

                break;
            }
        }

        return bin;
    }

    public static string Lsh(string bin, natch16 ls)
    {
        for (int i = 0; i < (int)ls.value; i++) bin = bin + "0";

        bin = bin.Length switch
        {
            > MaxLength => Slice(bin, bin.Length - MaxLength),
            _ => bin
        };

        switch (bin.Length)
        {
            case < MaxLength :
            {
                for (int i = 0; i < MaxLength; i++)
                {
                    bin = "0" + bin;
                    if (bin.Length == MaxLength)
                    {
                        break;
                    }
                }

                break;
            }
        }

        return bin;
    }

    public static string Lsh(string bin, natch32 ls)
    {
        for (int i = 0; i < (int)ls.value; i++) bin = bin + "0";

        bin = bin.Length switch
        {
            > MaxLength => Slice(bin, bin.Length - MaxLength),
            _ => bin
        };

        switch (bin.Length)
        {
            case < MaxLength :
            {
                for (int i = 0; i < MaxLength; i++)
                {
                    bin = "0" + bin;
                    if (bin.Length == MaxLength)
                    {
                        break;
                    }
                }

                break;
            }
        }

        return bin;
    }

    public static string Lsh(string bin, natch64 ls)
    {
        for (int i = 0; i < (int)ls.value; i++) bin = bin + "0";

        bin = bin.Length switch
        {
            > MaxLength => Slice(bin, bin.Length - MaxLength),
            _ => bin
        };

        switch (bin.Length)
        {
            case < MaxLength :
            {
                for (int i = 0; i < MaxLength; i++)
                {
                    bin = "0" + bin;
                    if (bin.Length == MaxLength)
                    {
                        break;
                    }
                }

                break;
            }
        }

        return bin;
    }

    public static string Rsh(string bin, int rs)
    {
        if ((double)rs < bin.Length) { bin = Slice(bin, 0, bin.Length - rs); }
        else
        {
            bin = "";
            for (int i = 0; i < MaxLength; i++) bin = bin + "0";
        }

        for (int i = 0; i < MaxLength; i++)
        {
            bin = "0" + bin;
            if (bin.Length == MaxLength)
            {
                break;
            }
        }

        return bin;
    }

    public static string Rsh(string bin, natch16 rs)
    {
        if ((double)rs < bin.Length) { bin = Slice(bin, 0, bin.Length - (int)rs); }
        else
        {
            bin = "";
            for (int i = 0; i < MaxLength; i++) bin = bin + "0";
        }

        for (int i = 0; i < MaxLength; i++)
        {
            bin = "0" + bin;
            if (bin.Length == MaxLength)
            {
                break;
            }
        }

        return bin;
    }

    public static string Rsh(string bin, natch32 rs)
    {
        if ((double)rs < bin.Length) { bin = Slice(bin, 0, bin.Length - (int)rs); }
        else
        {
            bin = "";
            for (int i = 0; i < MaxLength; i++) bin = bin + "0";
        }

        for (int i = 0; i < MaxLength; i++)
        {
            bin = "0" + bin;
            if (bin.Length == MaxLength)
            {
                break;
            }
        }

        return bin;
    }

    public static string Rsh(string bin, natch64 rs)
    {
        if ((double)rs < bin.Length) { bin = Slice(bin, 0, bin.Length - (int)rs); }
        else
        {
            bin = "";
            for (int i = 0; i < MaxLength; i++) bin = bin + "0";
        }

        for (int i = 0; i < MaxLength; i++)
        {
            bin = "0" + bin;
            if (bin.Length == MaxLength)
            {
                break;
            }
        }

        return bin;
    }

    protected static string Multiply(string bin1, string bin2)
    {
        string summ = "";
        for (int i = 0; i < MaxLength; i++)
        {
            summ += "0";
            if (summ.Length == MaxLength)
            {
                break;
            }
        }

        for (int i = 0; i <= bin2.Length - 1; i++)
            summ = bin2[bin2.Length - i - 1] switch
            {
                '1' => Add(summ, Lsh(bin1, i)),
                _ => summ
            };

        return summ;
    }

    public static binch ___Multiply(binch num1, binch num2)
    {
        string bin1 = Convert.ToString(num1.value);
        bin1 = Slice(bin1, 2);
        string bin2 = Convert.ToString(num2.value);
        bin2 = Slice(bin2, 2);
        return new binch(Multiply(bin1, bin2));
    }

    public static binch ___Multiply(binch num1, string num2)
    {
        string bin1 = Convert.ToString(num1.value);
        string bin2;
        bin1 = Slice(bin1, 2);
        bin2 = Slice(num2, 2);
        return new binch(Multiply(bin1, bin2));
    }

    public static binch ___Multiply(string num1, binch num2)
    {
        string bin2 = Convert.ToString(num2.value);
        string bin1;
        bin1 = Slice(num1, 2);
        bin2 = Slice(bin2, 2);
        return new binch(Multiply(bin1, bin2));
    }

    public static binch ___Multiply(string num1, string num2)
    {
        string bin1;
        string bin2;
        bin1 = Slice(num1, 2);
        bin2 = Slice(num2, 2);
        return new binch(Multiply(bin1, bin2));
    }
}