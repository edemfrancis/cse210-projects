using System;

namespace program
{
   public class WrittingAssignment : Assignment{

    private string _title = "";

    public string GetHistory(){
        return _title;
    }
    public void SetHistory(string number){
        _title = number;
    }    
     public string  GetWrittingHistory(){
            return $"The cause of {_title} by ";
        }
   }
}