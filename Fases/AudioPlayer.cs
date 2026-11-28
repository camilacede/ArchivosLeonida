using System.Runtime.InteropServices;
using System.Text;

namespace ArchivosLeonida.Fases
{
    public class AudioPlayer
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string comando, StringBuilder? retorno, int largo, IntPtr callback);

        private string ruta = Path.Combine(Path.GetTempPath(), "leonida_audio.mp3");
        private bool sonando = false;

        public void Reproducir(string audioBase64)
        {
            byte[] bytes = Convert.FromBase64String(audioBase64);
            File.WriteAllBytes(ruta, bytes);

            mciSendString("open \"" + ruta + "\" type mpegvideo alias leonida", null, 0, IntPtr.Zero);
            mciSendString("play leonida repeat", null, 0, IntPtr.Zero);
            sonando = true;
        }

        public void Detener()
        {
            if (sonando)
            {
                mciSendString("stop leonida", null, 0, IntPtr.Zero);
                mciSendString("close leonida", null, 0, IntPtr.Zero);
                sonando = false;
            }
        }
    }
}