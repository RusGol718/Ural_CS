#region

using Errors.SyntaxInvalidError.ErrorDatatypes;

#endregion

namespace Datatypes.Numbers.OtherNumbers.Hexadecimal;

public class kvalia : VOID, Interface_UBinch, Interface_Ural_Datatype
{
    public const string Reference = "К#";
    public const string DefaultValue = Reference + "0";
    public const int MaxLength = 6;
    public const uint MaxValue = 16777215U;
    public const uint MinValue = 0U;

    public kvalia(string _value) : base(_value)
    {
        if ((Slice(_value, 0, 2) == Reference) & (KvaliaCheck(_value).value == "ИСТИНА")) { this.value = _value; }
        else if ((Slice(_value, 0, 2) != Reference) &
                 (KvaliaCheck(Reference + _value).value == "ИСТИНА")) { this.value = Reference + _value; }
        else
        {
            SyntaxInvalidKvaliaDatatypeError er = new SyntaxInvalidKvaliaDatatypeError(0, 0);
            this.value = binch.DefaultValue;
        }

        if (Slice(_value, 0, 2).Length > shesch.MaxLength)
            //ошибка;
        {
            this.value = vosch.DefaultValue;
        }
    }


    public kvalia(ushort _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = this.NatchToKvalia(_value);
    }

    public kvalia(uint _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = this.NatchToKvalia(_value);
    }

    public kvalia(ulong _value) : base(_value)
    {
        this.subvalue = "+";
        this.value = this.NatchToKvalia(_value);
    }

    public dynamic NatchToKvalia(ushort _value)
    {
        int dec = Convert.ToInt32(_value);
        int val = 0;
        string result = "";
        switch (dec)
        {
            case 0 :
                return Reference + "0";
            case 1 :
                return Reference + "1";
            default :
            {
                while (dec > 0)
                {
                    val = dec % 16;

                    result = val switch
                    {
                        < 10 => result.Insert(0, Convert.ToChar(val + 48).ToString()),
                        _ => result.Insert(0, Convert.ToChar(val + 1030).ToString())
                    };

                    dec /= 16;
                }

                return Reference + result;
            }
        }
    }

    public dynamic NatchToKvalia(uint _value)
    {
        int dec = Convert.ToInt32(_value);
        int val = 0;
        string result = "";
        switch (dec)
        {
            case 0 :
                return Reference + "0";
            case 1 :
                return Reference + "1";
            default :
            {
                while (dec > 0)
                {
                    val = dec % 16;

                    result = val switch
                    {
                        < 10 => result.Insert(0, Convert.ToChar(val + 48).ToString()),
                        _ => result.Insert(0, Convert.ToChar(val + 1030).ToString())
                    };

                    dec /= 16;
                }

                return Reference + result;
            }
        }
    }

    public dynamic NatchToKvalia(ulong _value)
    {
        ulong dec = Convert.ToUInt64(_value);
        ulong val = 0;
        string result = "";
        switch (dec)
        {
            case 0 :
                return Reference + "0";
            case 1 :
                return Reference + "1";
            default :
            {
                while (dec > 0)
                {
                    val = dec % 16;

                    result = val switch
                    {
                        < 10 => result.Insert(0, Convert.ToChar(val + 48).ToString()),
                        _ => result.Insert(0, Convert.ToChar(val + 1030).ToString())
                    };

                    dec /= 16;
                }

                return Reference + result;
            }
        }
    }

    public static string ToEngHex(string _value)
    {
        _value = Slice(_value, 2);
        string new_ascii_hex = "";
        for (int i = 0; i < _value.Length; i++)
            new_ascii_hex += (uint)_value[i] switch
            {
                > 90 => Convert.ToChar((ulong)_value[i] - 975).ToString(),
                _ => _value[i]
            };

        return Reference + new_ascii_hex;
    }

    public static string ToEngHex(kvalia _value)
    {
        string new_value = Slice(Convert.ToString(_value.value), 2);
        string new_ascii_hex = "";
        for (int i = 0; i < new_value.Length; i++)
            new_ascii_hex += (uint)new_value[i] switch
            {
                > 90 => Convert.ToChar((ulong)new_value[i] - 975).ToString(),
                _ => new_value[i]
            };

        return Reference + new_ascii_hex;
    }

    public static string ToRusHex(string _value)
    {
        _value = Slice(_value, 2);
        string new_ascii_hex = "";
        for (int i = 0; i < _value.Length; i++)
            if (char.IsDigit(_value[i]))
            {
                new_ascii_hex += _value[i];
            }
            else
            {
                new_ascii_hex += (uint)_value[i] switch
                {
                    <= 90 => Convert.ToChar((ulong)_value[i] + 975).ToString(),
                    _ => _value[i]
                };
            }

        return Reference + new_ascii_hex;
    }

    public static string ToRusHex(kvalia _value)
    {
        string new_value = Slice(Convert.ToString(_value.value), 2);
        string new_ascii_hex = "";
        for (int i = 0; i < new_value.Length; i++)
            if (char.IsDigit(new_value[i]))
            {
                new_ascii_hex += new_value[i];
            }
            else
            {
                new_ascii_hex += (uint)new_value[i] switch
                {
                    <= 90 => Convert.ToChar((ulong)new_value[i] + 975).ToString(),
                    _ => new_value[i]
                };
            }

        return Reference + new_ascii_hex;
    }

    protected static RCI KvaliaCheck(string bin)
    {
        RCI flag = new RCI(true);
        if (Slice(bin, 0, 2) == binch.Reference)
        {
            for (int i = 2; i < bin.Length; i++)
                switch ((bin[i] == '0') | (bin[i] == '1') | (bin[i] == '2') | (bin[i] == '3') | (bin[i] == '4') |
                        (bin[i] == '5') | (bin[i] == '6') | (bin[i] == '7') | (bin[i] == '8') | (bin[i] == '9') |
                        (bin[i] == 'A') | (bin[i] == 'B') | (bin[i] == 'C') | (bin[i] == 'D') | (bin[i] == 'E') |
                        (bin[i] == 'F') | (bin[i] == 'А') | (bin[i] == 'Б') | (bin[i] == 'В') | (bin[i] == 'Г') |
                        (bin[i] == 'Д') | (bin[i] == 'Е'))
                {
                    case true :
                        flag = RCI.I(flag, flag);
                        break;
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
}