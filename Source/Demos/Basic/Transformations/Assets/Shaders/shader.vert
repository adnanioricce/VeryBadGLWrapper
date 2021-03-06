#version 330 core

layout(location = 0) in vec3 aPosition;
layout(location = 1) in vec4 aColor;
layout(location = 2) in vec2 aTexCoord;


out vec2 texCoord;
out vec4 fragColor;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
void main(void)
{
    texCoord = aTexCoord;
    fragColor = aColor;

    gl_Position =  projection * view * model * vec4(aPosition, 1.0);
}