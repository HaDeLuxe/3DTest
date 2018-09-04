using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Übung {
    class Game1Extended {

        //Translation Matrix

        //Matrix.CreateTranslation(Vector3 position)

        //Rotation around X Axis

        //Matrix.CreateRotationX(float angleInRadians);

        //Rotation around Y Axis

        //Matrix.CreateRotationY(float angleInRadians);

        //Rotation around Z Axis

        //Matrix.CreateRotationZ(float angleInRadians);

        //Rotation aroung arbitrary axis

        //Matrix.CreateFromAxisAngle(Vector3 axis, float angleInRadians);

        //Combine Matrixed

        Matrix result = Matrix.CreateRotationX(MathHelper.ToRadians(45)) * Matrix.CreateTranslation(new Vector3(10, 0, 0));



        //Creating a view Matrix
     
        //Matrix.CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector);
        /*
         cameraPosition: Location of the camera in 3d World
         cameraTarget: point in the world that the camera is looking at
         cameraUpVector: Direction that is up for the camera.
         */

        //Creating an orthographic projection
        //Matrix.CreateOrthographic(float widht, float height, float zNearPlane, float zFarPlane);


        //First method to create a persective projection
        //Matrix.CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance);
        //aspectRatio = graphics.PreferredBackPufferWidht / graphics.PreferredBackPufferHeight;

        //Second method to create a perspectice projection
        //Matrix.CreatePerspective(float width, float height, flaot nearPlaneDistance, float farPlaneDistance);
        /*
        width and height are the sizes of the viewing area ath the near clipping plane.
         */

        /*
         Custom Matrix:

        Matrix customMatrix = new Matrix(
        float m11, float m12, float m13,
        float m21, float m22, float m23,
        float m31, float m32, float m33);
         
         */
    }
}
