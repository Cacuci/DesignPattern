
namespace DesignPattern_2_Structural_2_2_Facade
{
    public class HardDrive
    {
        public byte[] Read(long lba, int size)
        {
            return new byte[2];
        }
    }
}
