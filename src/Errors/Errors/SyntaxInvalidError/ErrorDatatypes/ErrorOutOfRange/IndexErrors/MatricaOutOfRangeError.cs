namespace Errors.SyntaxInvalidError.ErrorDatatypes.ErrorOutOfRange;

public class MatricaOutOfRangeError : Error
{
    public MatricaOutOfRangeError(int _position_start, int _position_end,
        string _error_name = "Размерность матрицы  не в диапазоне: ",
        string _discription = "либо она больше размера натч64, либо она отрицательная") : base(_position_start,
        _position_end, _error_name, _discription)
    {
    }
}