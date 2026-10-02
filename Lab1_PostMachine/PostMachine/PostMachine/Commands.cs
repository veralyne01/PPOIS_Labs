using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    public class Commands
    {
        Tape newTape = new Tape();
        public Slider slider = new Slider();
        public void MakeLabel()
        {
            newTape.tape.Add(slider.position);
        }
        public void RemoveLabel()
        {
            newTape.tape.Remove(slider.position);
        }
        public void MoveRight(int step)
        {
            slider.position += step;
        }
        public void MoveLeft(int step)
        {
            slider.position -= step;
        }
        public bool CheckCell()
        {
            if (newTape.tape.Contains(slider.position)) return true;
            return false;
        }
    }
}
