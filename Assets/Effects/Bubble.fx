sampler uImage0 : register(s0);

float Length(float2 Vector) {
    float x = Vector.x;
    float y = Vector.y;
    return sqrt(x * x + y * y);
}

float4 PixelShaderFunction(float2 coords : TEXCOORD0) : COLOR0{
    float4 color = tex2D(uImage0, coords);
    if (!any(color))
        return color;
    float2 pos = float2(0.5, 0.5);
    float2 offset = coords - pos;
    return float4(color.rgb, color.a * Length(offset));
}

technique Technique1 {
    pass Test {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}