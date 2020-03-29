namespace DesignPattern_2_Structural_2_2_Facade
{
    public class Computer
    {
        private CPU cpu;
        private Memory memomy;
        private HardDrive hardDrive;

        public Computer()
        {
            cpu = new CPU();
            memomy = new Memory();
            hardDrive = new HardDrive();
        }      

        public void StartComputer()
        {
            cpu.Freeze();
            memomy.Load(1, new byte[3]);
            cpu.Jump(1);
            cpu.Execute();
        }
    }
}