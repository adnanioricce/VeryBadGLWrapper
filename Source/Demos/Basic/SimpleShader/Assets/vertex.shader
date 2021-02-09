﻿#version 330
layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec4 aColor;
out vec4 fColor;
void main()
{
	gl_Position = vec4(aPosition, 1.0);
	fColor = aColor;
}