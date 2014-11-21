using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal void OnNotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #region Private Fields

        private bool _isCalculated = false;
        private string _midResult = string.Empty;
        private string _endResult = string.Empty;
        private string _displayText = "0";
        private string _operation = string.Empty;

        #endregion

        #region Public Fields

        public bool IsCalculated
        {
            get
            {
                return _isCalculated;
            }
            set
            {
                _isCalculated = value;
                this.OnNotifyPropertyChanged("IsCalculated");
            }
        }

        public string MidResult
        {
            get
            {
                return _midResult;
            }
            set
            {
                _midResult = value;
                this.OnNotifyPropertyChanged("MidResult");
            }
        }

        public string EndResult
        {
            get
            {
                return _endResult;
            }
            set
            {
                _endResult = value;
                this.OnNotifyPropertyChanged("EndResult");
            }
        }

        public string DisplayText
        {
            get
            {
                return _displayText;
            }
            set
            {
                _displayText = value;
                this.OnNotifyPropertyChanged("DisplayText");
            }
        }

        public string Operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;
                this.OnNotifyPropertyChanged("Operation");
            }
        }

        #endregion

        #region Methods

        public void ShowNumber(string number)
        {
            if (DisplayText.Length > 14)
                return;
            if (String.IsNullOrEmpty(number))
                DisplayText = string.Empty;             
            else
            {
                if (IsCalculated)
                {
                    DisplayText = string.Empty;
                    IsCalculated = false;
                }
                if (DisplayText == "0")
                    DisplayText = string.Empty;
                DisplayText += number;
            }              
        }
     
        public void Calculate(string action)
        {
            MidResult = DisplayText;
            DisplayText = string.Empty;
            Operation = action;
            switch (action)
            {
                case "+":
                    Add();
                    break;
                case "-":
                    Subtract(); break;
                case "/":
                    Divide(); break;
                case "*":
                    Multiply(); break;
                case "^":
                    Power(); break;
                case "S":
                    SquareRoot(); break;
                default:
                    break;
            }
        }

        public void Add()
        {
            if (!String.IsNullOrEmpty(MidResult))
            {
                if (!String.IsNullOrEmpty(EndResult))
                {
                    EndResult = (decimal.Parse(EndResult) + decimal.Parse(MidResult)).ToString();
                    MidResult = string.Empty;
                    IsCalculated = true;
                    DisplayText = EndResult;
                }
                else
                {
                    EndResult = MidResult;
                    MidResult = string.Empty;
                }
            }
        }

        public void Subtract()
        {
            if (!String.IsNullOrEmpty(MidResult))
            {
                if (!String.IsNullOrEmpty(EndResult))
                {
                    EndResult = (decimal.Parse(EndResult) - decimal.Parse(MidResult)).ToString();
                    MidResult = string.Empty;
                    IsCalculated = true;
                    DisplayText = EndResult;
                }
                else
                {
                    EndResult = MidResult;
                    MidResult = string.Empty;
                }
            }
        }

        public void Multiply()
        {
            if (!String.IsNullOrEmpty(MidResult))
            {
                if (!String.IsNullOrEmpty(EndResult))
                {
                    EndResult = (decimal.Parse(EndResult) * decimal.Parse(MidResult)).ToString();
                    MidResult = string.Empty;
                    IsCalculated = true;
                    DisplayText = EndResult;
                }
                else
                {
                    EndResult = MidResult;
                    MidResult = string.Empty;
                }
            }
        }

        public void Divide()
        {
            try
            {
                if (!String.IsNullOrEmpty(MidResult))
                {
                    if (!String.IsNullOrEmpty(EndResult))
                    {
                        EndResult = (decimal.Parse(EndResult) / decimal.Parse(MidResult)).ToString();
                        MidResult = string.Empty;
                        IsCalculated = true;
                        DisplayText = EndResult;
                    }
                    else
                    {
                        EndResult = MidResult;
                        MidResult = string.Empty;
                    }
                }
            }
            catch (Exception)
            {
                DisplayText = "Cannot divide by 0";
                MidResult = string.Empty;
                EndResult = string.Empty;
                IsCalculated = false;
            }
            
        }

        public void Power()
        {
            if (!String.IsNullOrEmpty(MidResult))
            {
                if (!String.IsNullOrEmpty(EndResult))
                {
                    EndResult = Math.Pow(double.Parse(EndResult), double.Parse(MidResult)).ToString();
                    MidResult = string.Empty;
                    IsCalculated = true;
                    DisplayText = EndResult;
                }
                else
                {
                    EndResult = MidResult;
                    MidResult = string.Empty;
                }
            }
        }

        public void SquareRoot()
        {
           if (!String.IsNullOrEmpty(MidResult))
            {
                if (!String.IsNullOrEmpty(EndResult))
                {
                    EndResult = Math.Sqrt(double.Parse(MidResult)).ToString();
                    MidResult = string.Empty;
                    IsCalculated = true;
                    DisplayText = EndResult;
                }
                else
                {
                    EndResult = Math.Sqrt(double.Parse(MidResult)).ToString();
                    MidResult = string.Empty;
                    IsCalculated = true;
                    DisplayText = EndResult;
                }
                EndResult = string.Empty;
            }
        }

        public void Equals()
        {
            if (Operation != "S")
            {
                Calculate(Operation);
                IsCalculated = false;
                EndResult = string.Empty;
            }

        }

        public void Clear()
        {
            DisplayText = "0";
            MidResult = string.Empty;
            EndResult = string.Empty;
            IsCalculated = false;
        }

        #endregion
    }
}
