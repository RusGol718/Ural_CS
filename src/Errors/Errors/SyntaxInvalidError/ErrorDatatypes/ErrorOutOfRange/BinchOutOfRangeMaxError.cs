namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class BinchOutOfRangeMaxError : SyntaxInvalidBinchDatatypeError
{
    public BinchOutOfRangeMaxError(int _position_start, int _position_end,
        string _error_name = "Бинарное (двоичное) число не в диапазоне: ",
        string _discription = "число не должно превышать 18446744073709551615.") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}