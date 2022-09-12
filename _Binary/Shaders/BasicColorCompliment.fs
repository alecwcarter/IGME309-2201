#version 330

in vec3 Color;

uniform vec3 SolidColor = vec3(-1,-1,-1);
uniform bool ShouldInvert;

out vec4 Fragment;

void main()
{
	Fragment = vec4(Color,1);

	if(ShouldInvert)
		Fragment = vec4(1 - SolidColor.r, 1 - SolidColor.g, 1 - SolidColor.b, 1);
	
	if(SolidColor.r != -1.0 && SolidColor.g != -1.0 && SolidColor.b != -1.0)
		Fragment = vec4(SolidColor, 1);

	return;
}