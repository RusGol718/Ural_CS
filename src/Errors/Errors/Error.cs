//V2.0.5

#region

using System.Drawing;
using UralConsole = Colorful.Console;

#endregion

namespace Errors;

[Serializable]
public class Error : Exception
{
    public int position_start;
    public int position_end;
    public string error_name;
    public string discription;
    public readonly string Messenger;

    public Error(int _position_start, int _position_end, string _error_name, string _discription)
    {
        //Constructor
        this.position_start = _position_start;
        this.position_end = _position_end;
        this.error_name = _error_name;
        this.discription = _discription;
        if (this.position_start == this.position_end)
        {
            this.Messenger =
                $"Обнаружена ошибка:\n{this.error_name}{this.discription} в позиции {this.position_end}";
        }
        else
        {
            this.Messenger =
                $"Обнаружена ошибка:\n{this.error_name}{this.discription} в позициях от {this.position_end} до {this.position_end}";
        }
    }

    public override string ToString() => $"{this.error_name} {this.discription}";

    public override string Message
    {
        get
        {
            UralConsole.BackgroundColor = Color.Sienna;
            UralConsole.ForegroundColor = Color.Orange;
            Console.WriteLine(this.Messenger);
            Console.ResetColor();
            return this.Messenger;
        }
    }

    public Exception Visiv()
    {
        UralConsole.BackgroundColor = Color.Sienna;
        UralConsole.ForegroundColor = Color.Orange;
        Console.WriteLine(this.Messenger);
        Console.ResetColor();
        return new Exception(this.Messenger);
    }

    public void Execute()
    {
        try { throw this.Visiv(); }
        catch (Exception err)
        {
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}