using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class otelLinkedList:LinkedListADT
    {
        public override void InsertLast(object value)
        {


            Node oldLast = Head;
            Node newLast = new Node
            {
                Data = value
            };

            if (Head == null)

                Head = newLast;
            else
            {



                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }

                oldLast.Next = newLast;


                Size++;
            }
        }
        enum tip
        {
            personel
        }
        public override string DisplayGetElement(object position)
        {

            string temp = "";
            Node tmp = Head.Next;
            tip t;
            t = tip.personel;
            if ((int)t == (int)position)
            {

                temp += (Head.Data as Personel).staffNameSurname + "\n" +
                    (Head.Data as Personel).staffTcNo + "\n" +
                    (Head.Data as Personel).staffDepartment + "\n" +
                    (Head.Data as Personel).staffScore + "\n" +
                    (Head.Data as Personel).staffPhoneNumber +"\n" +
                    (Head.Data as Personel).staffAdress + "\n" +
                    (Head.Data as Personel).staffMail + "\n" +
                    (Head.Data as Personel).staffPosition+ "\n";

            }
            return temp;
        }
    }
}
