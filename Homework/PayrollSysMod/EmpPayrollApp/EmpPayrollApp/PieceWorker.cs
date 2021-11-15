using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    class PieceWorker : Employee
    {
        private decimal Wage { get; set; }
        private int Pieces { get; set; }

        public PieceWorker(string firstName, string lastName,
   string socialSecurityNumber, decimal w, int p) : base(firstName,lastName,socialSecurityNumber)
        {
            Wage = w;
            Pieces = p;
        }
public override decimal Earnings()
        {
            return Pieces*Wage;
        }

        public override string ToString()
        {
            return $"Piece Worker {base.ToString()}" +
            $"# of pieces: {Pieces}\n" +
            $"Wage: {Wage:C}\n" +
            $"Total earnings: {Earnings():C}";
        }
    }
}
