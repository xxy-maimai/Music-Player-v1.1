using NAudio.Wave;
using ATL;
using System.Net.WebSockets;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private AudioFileReader reader;
        private WaveOutEvent wave = new WaveOutEvent();
        private List<string> songs = new List<string>();
        private List<Track> tracks = new List<Track>();
        private int now_playing_index = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayOrPauseMusic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                songs.Add(openFileDialog1.FileName);
                Track track = new Track(openFileDialog1.FileName);
                tracks.Add(track);
                listBox1.Items.Add(track.Title);
            }
        }

        private void PlayOrPauseMusic()
        {
            if (now_playing_index != -1)
            {
                if (wave.PlaybackState == PlaybackState.Playing)
                {
                    timer1.Stop();
                    button2.Text = "播放";
                    wave.Pause();
                }
                else
                {
                    timer1.Start();
                    button2.Text = "暂停";
                    wave.Play();
                }
            }
            else
            {
                if (songs.Count > 0)
                {
                    now_playing_index = 0;
                    PlaySong(now_playing_index);
                }
                else MessageBox.Show("没有任何歌曲！", "提示");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (now_playing_index != -1)
            {
                now_playing_index = (now_playing_index + songs.Count - 1) % songs.Count;
                PlaySong(now_playing_index);
            }
            else
            {
                MessageBox.Show("没有任何歌曲！", "提示");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (now_playing_index != -1)
            {
                now_playing_index = (now_playing_index + 1) % songs.Count;
                PlaySong(now_playing_index);
            }
            else
            {
                MessageBox.Show("没有任何歌曲！", "提示");
            }
        }

        private int GetProgress()
        {
            if (reader == null || reader.Length == 0)
            {
                return 0;
            }
            else
            {
                return (int)(reader.Position * 100.0 / reader.Length);
            }
        }

        private void SetProgress(int perc)
        {
            if (reader == null) return;
            long newpos = (long)(reader.Length * perc / 100.0);
            reader.Position = newpos;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (reader != null && wave != null && wave.PlaybackState == PlaybackState.Playing)
            {
                int progress = GetProgress();
                trackBar1.Value = progress;
                UpdateTime();
            }
            if (wave.PlaybackState == PlaybackState.Stopped)
            {
                now_playing_index = (now_playing_index + 1) % songs.Count;
                PlaySong(now_playing_index);
            }
        }

        private void UpdateTime()
        {
            if (reader != null)
            {
                label2.Text = $"{reader.CurrentTime:mm\\:ss} / {reader.TotalTime:mm\\:ss}";
            }
        }

        private void PlaySong(int index)
        {
            if (index != -1)
            {
                wave.Stop();
                if (reader != null) reader.Dispose();
                if (wave != null) wave.Dispose();
                reader = new AudioFileReader(songs[index]);
                wave = new WaveOutEvent();
                wave.Init(reader);
                PlayOrPauseMusic();
                label1.Text = $"正在播放：{tracks[index].Title}";
                listBox1.SelectedIndex = index;
                if (tracks[index].EmbeddedPictures != null && tracks[index].EmbeddedPictures.Count > 0)
                {
                    var pic = tracks[index].EmbeddedPictures[0];
                    byte[] data = pic.PictureData;
                    var ms = new MemoryStream(data);
                    pictureBox1.Image = new Bitmap(ms);
                }
                else pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("没有任何歌曲！", "提示");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (reader == null) return;
            else
            {
                timer1.Stop();
                double percent = trackBar1.Value / 100.0;
                TimeSpan prevTime = TimeSpan.FromMilliseconds(reader.TotalTime.TotalMilliseconds * percent);

                label2.Text = label2.Text = $"{prevTime:mm\\:ss} / {reader.TotalTime:mm\\:ss}";
            }
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (reader == null) return;

            long newpos = (long)(reader.Length * trackBar1.Value / 100.0);
            reader.Position = newpos;

            UpdateTime();
            timer1.Start();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndices.Count > 0 && listBox1.SelectedIndices[0] != now_playing_index)
            {
                now_playing_index = listBox1.SelectedIndices[0];
                PlaySong(now_playing_index);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
