Shader "Unlit/ChangeScene"
{
    Properties
    {
        _Tex ("Texture", 2D) = "white" {}
        _Tex1 ("Texture1", 2D) = "white" {}
        _SliderY("_Slider",float) =1
        _SliderX("_Slider",float) =1
        _ScaleSlider("_Slider",Range(0,10)) = 1
    }
    SubShader
    {
         Tags { "RenderType"="Transparent""Queue" = "Transparent"}
        //ZWrite off
        Blend SrcAlpha OneMinusSrcAlpha
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };

            sampler2D _Tex;
            float4 _Tex_ST;
            sampler2D _Tex1;
            float4 _Tex1_ST;
            float _SliderY;
            float _SliderX;
            float _ScaleSlider;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _Tex);
                o.uv1 = TRANSFORM_TEX(v.uv1,_Tex1);

                return o;
            }

            float4 frag (v2f i) : SV_Target
            {
                
                i.uv -= float2(0.5,0.5);
				i.uv.y *= _SliderY;
                i.uv.x *= _SliderX;
                i.uv *=_ScaleSlider;
				i.uv += float2(0.5,0.5);

                float4 col = tex2D(_Tex, i.uv);
                float4 col1 = tex2D(_Tex1, i.uv1);
                col1.a*=1-col.a;
                // col1.w = 1；
                return col1;
            }
            ENDCG
        }
    }
}
