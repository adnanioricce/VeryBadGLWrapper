﻿#version 330 core
layout (location = 0) in vec3 aPosition;
in vec4 aColor;
out vec4 fColor;
uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
	gl_Position = projection * view * model * vec4(aPosition, 1.0);
	fColor = aColor;
}