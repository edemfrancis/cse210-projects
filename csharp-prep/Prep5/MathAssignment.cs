using System;

namespace program
{
   public class MathAssignment : Assignment{

    private string _textbookSection = "";
    private string _problems = "";

    public string GetTextbook(){
        return _textbookSection;
    }
    public void SetTextbook(string Textbookname){
        _textbookSection = Textbookname;
    }    

    public string GetProblems(){
        return _problems;
    }
    public void SetProblems(string problemsname){
        _problems = problemsname;
    }
     public string  GetMathSummary(){
            return $"Section {_textbookSection}, Problems {_problems}";
        }
   }
}