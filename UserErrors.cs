using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    internal abstract class UserErrors
    {
       public abstract string UEMessage();
    }

   class NumericInputError : UserErrors
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserErrors
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    class ThinkingError : UserErrors
    {
        public override string UEMessage()
        {
            return "You thought wrong. This fired an error!";
        }
    }
    class SelfishError : UserErrors
    {
        public override string UEMessage()
        {
            return "You've been selfish. This fired an error!";
        }
    }
    class LyingError : UserErrors
    {
        public override string UEMessage()
        {
            return "You are lying. This fired an error!";
        }
    }
}
