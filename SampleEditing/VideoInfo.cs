using System;
using System.Collections.Generic;
using System.Text;

public class VideoInfo
{
    public VideoInfo()
    {
    }

    // OUTPUT PROPERTIES

    string _start = "";
    string _exception = "";
    string _ffmpegoutput = "";

    // ERROR CODE
    private int _errorcode = 0;

    // General values
    string _filename = "";
    int _hours = 0;
    int _minutes = 0;
    int _seconds = 0;
    int _duration_sec = 0;
    string _duration = "";
    string start_position = "";

    int _input_width = 0;
    int _input_height = 0;
    int _width = 0;
    int _height = 0;

    string _input_type = ""; // audio or video
    string _output_type = ""; // audio or video

    // Audio values
    string _output_audio_codec = "";
    string _output_audio_samplingrate = "";
    string _output_audio_channel = "";
    string _output_audio_bitrate = "";

    string _input_audio_codec = "";
    string _input_audio_samplingrate = "";
    string _input_audio_channel = "";
    string _input_audio_bitrate = "";

    // Video Values
    string _output_video_codec = "";
    string _output_video_bitrate = "";
    string _output_video_framerate = "";

    string _input_video_codec = "";
    string _input_video_bitrate = "";
    string _input_video_framerate = "";

    // New Properties
    string _title = "";
    string _producer = "";
    string _footage = "";
    string _music = "";

    private long _processedsize = 0; // kb
    private int _processedtime = 0; // in seconds
    private long _totalsize = 0; // kb
    private double _processingleft = 100; // %
    private double _processingcompleted = 0; // %
    private string _processid = "";

    public string ProcessID
    {
        set { _processid = value; }
        get { return _processid; }
    }
    public long ProcessedSize
    {
        set { _processedsize = value; }
        get { return _processedsize; }
    }

    public int ProcessedTime
    {
        set { _processedtime = value; }
        get { return _processedtime; }
    }

    public long TotalSize
    {
        set { _totalsize = value; }
        get { return _totalsize; }
    }

    public double ProcessingLeft
    {
        set { _processingleft = value; }
        get { return _processingleft; }
    }

    public double ProcessingCompleted
    {
        set { _processingcompleted = value; }
        get { return _processingcompleted; }
    }


    public string FileName
    {
        get
        {
            return _filename;
        }
        set
        {
            _filename = value;
        }
    }

    public string Duration
    {
        get
        {
            return _duration;
        }
        set
        {
            _duration = value;
        }
    }

    public int Duration_Sec
    {
        get
        {
            return _duration_sec;
        }
        set
        {
            _duration_sec = value;
        }
    }

    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            _hours = value;
        }
    }

    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            _minutes = value;
        }
    }

    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            _seconds = value;
        }
    }

    public string Start
    {
        get
        {
            return _start;
        }
        set
        {
            _start = value;
        }
    }

    public int ErrorCode
    {
        get
        {
            return _errorcode;
        }
        set
        {
            _errorcode = value;
        }
    }

    public string ErrorMessage
    {
        get
        {
            return _exception;
        }
        set
        {
            _exception = value;
        }
    }

    public string FFMPEGOutput
    {
        get
        {
            return _ffmpegoutput;
        }
        set
        {
            _ffmpegoutput = value;
        }
    }

    // Output Properties

    public string Acodec
    {
        get
        {
            return _output_audio_codec;
        }
        set
        {
            _output_audio_codec = value;
        }
    }

    public string Vcodec
    {
        get
        {
            return _output_video_codec;
        }
        set
        {
            _output_video_codec = value;
        }
    }

    public string SamplingRate
    {
        get
        {
            return _output_audio_samplingrate;
        }
        set
        {
            _output_audio_samplingrate = value;
        }
    }

    public string Channel
    {
        get
        {
            return _output_audio_channel;
        }
        set
        {
            _output_audio_channel = value;
        }
    }

    public string Audio_Bitrate
    {
        get
        {
            return _output_audio_bitrate;
        }
        set
        {
            _output_audio_bitrate = value;
        }
    }

    public string Video_Bitrate
    {
        get
        {
            return _output_video_bitrate;
        }
        set
        {
            _output_video_bitrate = value;
        }
    }

    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            _width = value;
        }
    }

    public int Height
    {
        get
        {
            return _height;
        }
        set
        {
            _height = value;
        }
    }

    public string FrameRate
    {
        get
        {
            return _output_video_framerate;
        }
        set
        {
            _output_video_framerate = value;
        }
    }

    public string Type
    {
        get
        {
            return _output_type;
        }
        set
        {
            _output_type = value;
        }
    }

    // Input Properties

    public string Input_Acodec
    {
        get
        {
            return _input_audio_codec;
        }
        set
        {
            _input_audio_codec = value;
        }
    }

    public string Input_Vcodec
    {
        get
        {
            return _input_video_codec;
        }
        set
        {
            _input_video_codec = value;
        }
    }

    public string Input_SamplingRate
    {
        get
        {
            return _input_audio_samplingrate;
        }
        set
        {
            _input_audio_samplingrate = value;
        }
    }

    public string Input_Channel
    {
        get
        {
            return _input_audio_channel;
        }
        set
        {
            _input_audio_channel = value;
        }
    }

    public string Input_Audio_Bitrate
    {
        get
        {
            return _input_audio_bitrate;
        }
        set
        {
            _input_audio_bitrate = value;
        }
    }

    public string Input_Video_Bitrate
    {
        get
        {
            return _input_video_bitrate;
        }
        set
        {
            _input_video_bitrate = value;
        }
    }

    public int Input_Width
    {
        get
        {
            return _input_width;
        }
        set
        {
            _input_width = value;
        }
    }

    public int Input_Height
    {
        get
        {
            return _input_height;
        }
        set
        {
            _input_height = value;
        }
    }

    public string Input_FrameRate
    {
        get
        {
            return _input_video_framerate;
        }
        set
        {
            _input_video_framerate = value;
        }
    }

    public string Input_Type
    {
        get
        {
            return _input_type;
        }
        set
        {
            _input_type = value;
        }
    }

    public string Music
    {
        get
        {
            return _music;
        }
        set
        {
            _music = value;
        }
    }
    public string Footage
    {
        get
        {
            return _footage;
        }
        set
        {
            _footage = value;
        }
    }
    public string Producer
    {
        get
        {
            return _producer;
        }
        set
        {
            _producer = value;
        }
    }
    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }
}

