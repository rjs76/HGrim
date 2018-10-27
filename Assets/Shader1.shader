Shader "Unlit/Shader1"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Color("Colour", Color) = (1,1,1,1)
	}
	
	SubShader
	{

		Cull off 

		Pass{
			
			CGPROGRAM

			#pragma vertex vertexFunc
			#pragma fragment fragmentFunc
			#include "UnityCG.cginc"
			
			sampler2D _MainTex;

			struct v2f{
				float4 pos :SV_POSITION;
				half2 uv : TEXCOORD0;
			};

			v2f vertexFunc(appdata_base v){
				v2f o;
				//Putting vertics in the right place 
				o.pos =UnityObjectToClipPos(v.vertex);
				o.uv = v.texcoord;
				
				return o;
			}
			fixed4 _Color;

			float4 _MainTex_TexelSize;

			fixed4 fragmentFunc(v2f i) : COLOR{
				half4 c = tex2D(_MainTex, i.uv);
				c.rgb *= c.a; 
				half4 outlineC = _Color;
				outlineC.a *= ceil(c.a);
				outlineC.rgb *= outlineC.a;

				fixed upAlpha = tex2D(_MainTex, i.uv + fixed2(0, _MainTex_TexelSize.y)).a;
				fixed downAlpha = tex2D(_MainTex, i.uv + fixed2(0, _MainTex_TexelSize.y)).a;
				fixed rightAlpha = tex2D(_MainTex, i.uv + fixed2(_MainTex_TexelSize.x, 0)).a;
				fixed leftAlpha = tex2D(_MainTex, i.uv + fixed2(_MainTex_TexelSize.x, 0)).a;

				return lerp(outlineC, c, ceil(upAlpha * downAlpha * rightAlpha * leftAlpha));
				 
			}

			ENDCG
			}
	 }
}








/*
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv);
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG
		}
	}
}
*/