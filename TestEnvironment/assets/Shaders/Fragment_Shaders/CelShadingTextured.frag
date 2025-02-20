#version 330 core

    struct Material 
    {
        sampler2D diffuse;
        sampler2D specular;
        float shininess;
        vec2 tile;
    };

    struct DirectionalLight 
    {
        vec3 direction;
  
        vec3 ambient;
        vec3 diffuse;
        vec3 specular;
    };
    struct PointLight 
    {
        vec3 position;
  
        vec3 ambient;
        vec3 diffuse;
        vec3 specular;

        float constant;
        float linear;
        float quadratic;
    };
    struct SpotLight 
    {
        vec3 position;
        vec3 direction;
  
        vec3 ambient;
        vec3 diffuse;
        vec3 specular;

        float cutOff;
        float outerCutOff;

        float constant;
        float linear;
        float quadratic;
    };

    struct LightLevel
    {
        float minVal;
        float maxVal;

        float lightness;

        vec3 tint;
    };

    
    //fragment/pixel color after calculations
    out vec4 FragColor;
    
    //passed from vertex-shader
    in vec3 Normal;
    in vec3 FragPos;
    in vec2 TexCoord;

    //uniforms
    uniform Material material;

    uniform int Num_DirLights;
    uniform DirectionalLight dirLights[4];
    
    uniform int Num_PointLights;
    uniform PointLight pointLights[32];
        
    uniform int Num_SpotLights;
    uniform SpotLight spotLights[16];

    uniform int Num_LightLevels;
    uniform LightLevel lightLevels[8];

    uniform vec3 viewPos;

    //function prototypes (they need to be declared before being called like in c)
    float CalcDirectionalLight(DirectionalLight light, vec2 texCoords, vec3 normal, vec3 viewDir);
    float CalcPointLight(PointLight light, vec2 texCoords, vec3 normal, vec3 viewDir);
    float CalcSpotLight(SpotLight light, vec2 texCoords, vec3 normal, vec3 viewDir);

    void main() 
    {

        //scale the texcoords to fit the specified tiling
        vec2 normTexCoords = material.tile * TexCoord;

        //get surface normal and the dir the light is coming from
        vec3 norm = normalize(Normal);

        //get the angle between the reflected light-ray and the view-direction        
        vec3 viewDir = normalize(viewPos - FragPos);
     
        //for(int i = 0; i < Num_DirLights; i++) //
        //{
        //    result += CalcDirectionalLight(dirLights[i], normTexCoords, norm, viewDir);
        //}
        
        //for(int i = 0; i < Num_PointLights; i++)
        //{
        //    result += CalcPointLight(pointLights[i], normTexCoords, norm, viewDir);
        //}
        //
        //for(int i = 0; i < Num_SpotLights; i++)
        //{
        //    result += CalcSpotLight(spotLights[i], normTexCoords, norm, viewDir);
        //}
        float result =0.0;
        result += CalcDirectionalLight(dirLights[0], normTexCoords, norm, viewDir);
        result *= 2; //with only dir lights it's a bit weak

        vec4 color = texture(material.diffuse, normTexCoords);

        for(int i = 0; i < Num_LightLevels; i++)
        {
            if(result > lightLevels[i].minVal && result < lightLevels[i].maxVal)
            {
                //float dif = result - lightLevels[i].lightness; //calc difference between cur lightlevel and the desired one
                result = lightLevels[i].lightness; //result -dif //subtract to get the cur lightness to the desired lightness
                color *= vec4(lightLevels[i].tint, 1.0);
            }

        }
        
        //color = vec4(color.rgb * vec3(0.55, 0.25, 0.2), color.a);
        //color = vec4(color.rgb * vec3(0.4, 0.2, 0.2), color.a);
        //color = vec4(color.rgb * vec3(1.0, 0.75, 0.75), color.a);
        FragColor = vec4(color.rgb * result, color.a); //vec4(color.rgb * result, color.a); //color.rgb * result, color.a
    }

    float CalcDirectionalLight(DirectionalLight light,vec2 texCoords, vec3 normal, vec3 viewDir)
    {
        //explanaition: https://learnopengl.com/Lighting/Light-casters, LearnOpenGL page 137

        //diffuse----------------------------------
        //vec3 lightDir = normalize(light.position - FragPos);
        vec3 lightDir = normalize(-light.direction);

        //dot product between surface-normal and light-dir, the clamped to get a value between 0-1, would otherwise be neg. if the angle was greater than 90� 
        float diff = max(dot(normal, lightDir), 0.0);
        float diffuse = (light.diffuse.x * diff) + (light.diffuse.y * diff) + (light.diffuse.z * diff);

        //ambient----------------------------------
        float ambient = (light.ambient.x * 0.5) + (light.ambient.y * 0.5) + (light.ambient.z * 0.5); //light.ambient * material.ambient; //* 0.5 because it's ambient

        //specular----------------------------------
        vec3 reflectDir = reflect(-lightDir, normal); //lightDir negated, because reflect() wants a Vec3 pointing from the light-source toward the fragment

        //the shininess-value dictates how focused the spot of reflected light is
        //float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess * 128);
        //float specular = (light.specular.x * spec) + (light.specular.y * spec) + (light.specular.z * spec);

        return (ambient + diffuse) * 0.33; //+ specular

    }

    float CalcPointLight(PointLight light, vec2 texCoords, vec3 normal, vec3 viewDir)
    {
        //explanaition: https://learnopengl.com/Lighting/Light-casters, LearnOpenGL page 141

        float dist = length(light.position - FragPos);
        float attenuation = 1.0 / (light.constant + light.linear * dist + light.quadratic * (dist * dist)); 

        //diffuse----------------------------------
        //get surface normal and the dir the light is coming from
        vec3 lightDir = normalize(light.position - FragPos);

        //dot product between surface-normal and light-dir, the clamped to get a value between 0-1, would otherwise be neg. if the angle was greater than 90� 
        float diff = max(dot(normal, lightDir), 0.0);
        float diffuse = (light.diffuse.x * diff) + (light.diffuse.y * diff) + (light.diffuse.z * diff);

        //ambient----------------------------------
        float ambient = (light.ambient.x * 0.5) + (light.ambient.y * 0.5) + (light.ambient.z * 0.5); //light.ambient * material.ambient; //* 0.5 because it's ambient

        //specular----------------------------------
        vec3 reflectDir = reflect(-lightDir, normal); //lightDir negated, because reflect() wants a Vec3 pointing from the light-source toward the fragment

        //the shininess-value dictates how focused the spot of reflected light is
        //float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess * 128);
        //float specular = (light.specular.x * spec) + (light.specular.y * spec) + (light.specular.z * spec);

        return ((ambient * attenuation) + (diffuse * attenuation)) * 0.33; // + (specular * attenuation)
    }

    float CalcSpotLight(SpotLight light, vec2 texCoords, vec3 normal, vec3 viewDir)
    {
        //explanaition: https://learnopengl.com/Lighting/Light-casters, LearnOpenGL page 143

        //vec2 normTexCoords = material.tile * TexCoord;
        vec2 normTexCoords = texCoords;
        //diffuse----------------------------------
        //get surface normal and the dir the light is coming from
        vec3 norm = normalize(Normal);
        vec3 lightDir = normalize(light.position - FragPos);

        //angle between spotlight-direction and the vector from the fragment to the light
        float theta = dot(lightDir, normalize(-light.direction));
        float epsilon = light.cutOff - light.outerCutOff;
        float intensity = clamp((theta - light.outerCutOff) / epsilon, 0.00, 1.0);

        //dot product between surface-normal and light-dir, the clamped to get a value between 0-1, would otherwise be neg. if the angle was greater than 90� 
        float diff = max(dot(norm, lightDir), 0.0);
        float diffuse = (light.diffuse.x * diff) + (light.diffuse.y * diff) + (light.diffuse.z * diff);

        //ambient----------------------------------
        float ambient = (light.ambient.x * 0.5) + (light.ambient.y * 0.5) + (light.ambient.z * 0.5); //light.ambient * material.ambient; //* 0.5 because it's ambient

        //specular----------------------------------
        //get the angle betwee the reflected light-ray and the view-direction        
        vec3 reflectDir = reflect(-lightDir, norm); //lightDir negated, because reflect() wants a Vec3 pointing from the light-source toward the fragment

        //the shininess-value dictates how focused the spot of reflected light is
        //float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess * 128);
        //float specular = (light.specular.x * spec) + (light.specular.y * spec) + (light.specular.z * spec);

        //attenuation
        float distance    = length(light.position - FragPos);
        float attenuation = 1.0 / (light.constant + light.linear * distance + light.quadratic * (distance * distance));    
        ambient  *= attenuation; 
        diffuse   *= attenuation;
        //specular *= attenuation; 

        return (ambient + (diffuse * intensity)) * 0.33; //+ (specular * intensity)
    }
