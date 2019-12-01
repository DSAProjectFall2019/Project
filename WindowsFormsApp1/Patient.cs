using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
	class Patient {
		private int ticketno;
		private string name;
		private char gender;
		private string bloodType;
		private string diseaseType;
		public void Dataentry(string nam, string btype, string dtype, char sex, int num) {
			name = nam;
			bloodType = btype;
			diseaseType = dtype;
			gender = sex;
			ticketno = num;
		}
		public string dispName() {
			return name;
		}
		public string dispblood() {
			return bloodType;
		}
		public string dispdisease() {
			return diseaseType;
		}
		public char dispsex() {
			return gender;
		}
		public int dispnumber() {
			return ticketno;
		}
	}
}
