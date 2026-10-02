using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Commands commandSet = new Commands();
            Console.WriteLine("---------------\nPOST MACHINE IMITATION\n---------------\n");
            do
            {
                Console.WriteLine($"CURRENT POSITION: {commandSet.slider.position}\n" +
                    "Choose the command:\n1. New label \n2. Remove label \n3. Move left \n4. Move right \n5. New tape \n6. Check cell \n7. Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        commandSet.MakeLabel();
                        break;
                    case 2:
                        commandSet.RemoveLabel();
                        break;
                    case 3:
                        int pos = InputValidator.ValidateInt();
                        commandSet.MoveLeft(pos);
                        break;
                    case 4:
                        pos = InputValidator.ValidateInt();
                        commandSet.MoveRight(pos);
                        break;
                    case 5:
                        commandSet = new Commands();
                        break;
                    case 6:
                        if (commandSet.CheckCell())
                        {
                            Console.WriteLine("Current cell is already labelled\n");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Current cell is not labelled\n");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (input != 7);
            return;
        }
    }
}
