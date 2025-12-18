using Microsoft.ML;
using Microsoft.ML.Data;

public class StarDataRaw
{
    //For encapsulation, normally these are private. However, for the ML feature this needs to be overruled and turned public
    [LoadColumn(0)]
    public float _TempK{get; set;}
    [LoadColumn(1)]
    public float _Lum{get; set;}
    [LoadColumn(2)]
    public float _Radius{get; set;}
    [LoadColumn(3)]
    public float _AbsoluteMag{get; set;}
    [LoadColumn(4)]
    [ColumnName("Label")]
    public int Label{get; set;}
    [LoadColumn(5)]
    public string _SpectralClass{get; set;}
    [LoadColumn(6)]
    public string _Color{get; set;}

//I orginally wrote it like this, but if I want to do the ML feature, I need to use the property feature. 
// public double _TempK;
//     public double _Lum;
//     public double _AbsoluteMag;
//     public double _Radius;


//     public int _TargetStarType;

//     public string _SpectralClass;
//     public string _Color;

    public StarDataRaw(){}
    
    public StarDataRaw(float temp, float lum, float rad, float absmag, int target, string c, string spectral)
    {
        _TempK = temp;
        _Lum = lum;
        _Radius = rad;
        _AbsoluteMag = absmag;
        Label = target;
        _SpectralClass = spectral;
        _Color = c;
    }

    //I wrote this according to what you said with class, but with
    //what I want to do with ML, I need to do the property thing. 
    // public void setTemp(double t)
    // {
    //     this._TempK = t;
    // }

    // public void setLuminosity(double l)
    // {
    //     this._Lum = l;
    // }

    // public void setAbsoluteMagnitute(double am)
    // {
    //     this._AbsoluteMag = am;
    // }

    // public void setRadius(double r)
    // {
    //     this._Radius = r;
    // }
    // public void setTargetStarType(int tst)
    // {
    //     this._TargetStarType = tst;
    // }

    // public void setSpectralClass(string sc)
    // {
    //     this._SpectralClass = sc;
    // }
    // public void setColor(string c)
    // {
    //     this._Color = c;
    // }

    // public double getTemp()
    // {
    //     return this._TempK;
    // }

    // public double getLuminosity()
    // {
    //     return this._Lum;
    // }

    // public double getAbsoluteMagnitute()
    // {
    //     return this._AbsoluteMag;
    // }

    // public double getRadius()
    // {
    //     return this._Radius;
    // }
    // public int getTargetStarType()
    // {
    //     return this._TargetStarType;
    // }

    // public string getSpectralClass()
    // {
    //     return this._SpectralClass;
    // }
    // public string getColor()
    // {
    //     return this._Color;
    // }
}