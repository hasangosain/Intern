using System;

// Interfaces for movement
public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public interface IDriveable
{
    void Drive();
}

// Classes implementing movement interfaces
public class Airplane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Airplane is flying in the sky.");
    }
}

public class Fish : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Fish is swimming in the water.");
    }
}

public class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Car is driving on the road.");
    }
}

public class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying above the pond.");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming in the pond.");
    }
}

// MediaPlayer interface
public interface IMediaPlayer
{
    void Play();
    void Pause();
    void Stop();
}

// AudioPlayer implementation
public class AudioPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("AudioPlayer is playing music.");
    }

    public void Pause()
    {
        Console.WriteLine("AudioPlayer paused.");
    }

    public void Stop()
    {
        Console.WriteLine("AudioPlayer stopped.");
    }
}

// VideoPlayer implementation
public class VideoPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("VideoPlayer is playing video.");
    }

    public void Pause()
    {
        Console.WriteLine("VideoPlayer paused.");
    }

    public void Stop()
    {
        Console.WriteLine("VideoPlayer stopped.");
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Movement examples
        Airplane airplane = new Airplane();
        airplane.Fly();

        Fish fish = new Fish();
        fish.Swim();

        Car car = new Car();
        car.Drive();

        Duck duck = new Duck();
        duck.Fly();
        duck.Swim();

        Console.WriteLine();

        // Media player examples
        IMediaPlayer audioPlayer = new AudioPlayer();
        audioPlayer.Play();
        audioPlayer.Pause();
        audioPlayer.Stop();

        Console.WriteLine();

        IMediaPlayer videoPlayer = new VideoPlayer();
        videoPlayer.Play();
        videoPlayer.Pause();
        videoPlayer.Stop();
    }
}
