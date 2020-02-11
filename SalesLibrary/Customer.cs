using System;
using System.Collections.Generic;
using System.Text;

namespace TurneryAndAccess {
    public class Customer {

        private static int NextId = 1;
        public int Id { get;private set; }
        public string Name { get; set; }
        //get;set holds code that would've been
        //private string _Name  public string Name { {get return this._Name;}  {set this._Name = value;} }
        private bool IsNationalAccount { get; set; }

        public override string ToString() {
            return $"Id = {this.Id}, Name = {this.Name}, NAccount = {this.IsNationalAccount}";
        }

        static Customer() {
            NextId = 21;
        }
            //read file to get the next id to be assigned

        public void NationalAccount(string yesOrno) {
            this.IsNationalAccount = yesOrno.Equals("yes") ? true : false;
        }

        public static string PrintNextId() {
            return$"{NextId}";
        }

        public Customer(string Name) {
            this.Id = NextId;
            this.Name = Name;
            NextId++;
        }
    }
}
