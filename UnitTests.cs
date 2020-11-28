using System;
using NUnit.Framework;

namespace P6___Áreas
{
    [TestFixture]
    class UnitTests
    {

        [Test]
        [TestCase(TestName = "Área de un cuadrado")]
        public void CalcularAreaCuadrado()
        {
            // 2*2=4
            //Arrange : Inicializar las variables
            decimal cuadrado1Lado1 = 2;
            decimal cuadrado1Lado2 = 2;

            //Act : llamar al metodo a testear
            string resultado1 = Calculator.Cuadrado(cuadrado1Lado1, cuadrado1Lado2);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual("4", resultado1);

            //2*5= Error (Los lados deben ser iguales)
            decimal cuadrado2Lado1 = 2;
            decimal cuadrado2Lado2 = 5;

            string resultado2 = Calculator.Cuadrado(cuadrado2Lado1, cuadrado2Lado2);
            Assert.AreEqual("Error", resultado2);

            //10*0= Error
            decimal cuadrado3Lado1 = 10;
            decimal cuadrado3Lado2 = 0;

            string resultado3 = Calculator.Cuadrado(cuadrado3Lado1, cuadrado3Lado2);
            Assert.AreEqual("Error", resultado3);

            //-70*-908= Error
            decimal cuadrado4Lado1 = -70;
            decimal cuadrado4Lado2 = -908;

            string resultado4 = Calculator.Cuadrado(cuadrado4Lado1, cuadrado4Lado2);
            Assert.AreEqual("Error", resultado4);

            //-5*3= Error
            decimal cuadrado5Lado1 = -5;
            decimal cuadrado5Lado2 = 3;

            string resultado5 = Calculator.Cuadrado(cuadrado5Lado1, cuadrado5Lado2);
            Assert.AreEqual("Error", resultado5);

            //0*0= Error
            decimal cuadrado6Lado1 = 0;
            decimal cuadrado6Lado2 = 0;

            string resultado6 = Calculator.Cuadrado(cuadrado6Lado1, cuadrado6Lado2);
            Assert.AreEqual("Error", resultado6);

            //4.5*4.5= 20.25
            decimal cuadrado7Lado1 = 4.5M;
            decimal cuadrado7Lado2 = 4.5M;

            string resultado7 = Calculator.Cuadrado(cuadrado7Lado1, cuadrado7Lado2);
            Assert.AreEqual("20.25", resultado7);
        }

        [Test]
        [TestCase(TestName = "Área de un rectángulo")]
        public void CalcularAreaRectangulo()
        {
            //2*5= Error
            decimal rectangulo2Lado1 = 2;
            decimal rectangulo2Lado2 = 5;

            string resultado2 = Calculator.Rectangulo(rectangulo2Lado1, rectangulo2Lado2);
            Assert.AreEqual("10", resultado2);

            // 2*2=4
            decimal rectangulo1Lado1 = 2;
            decimal rectangulo1Lado2 = 2;

            string resultado1 = Calculator.Rectangulo(rectangulo1Lado1, rectangulo1Lado2);
            Assert.AreEqual("Error", resultado1);

            //10*0= Error
            decimal rectangulo3Lado1 = 10;
            decimal rectangulo3Lado2 = 0;

            string resultado3 = Calculator.Rectangulo(rectangulo3Lado1, rectangulo3Lado2);
            Assert.AreEqual("Error", resultado3);

            //-10*4= Error
            decimal rectangulo4Lado1 = -10;
            decimal rectangulo4Lado2 = 4;

            string resultado4 = Calculator.Rectangulo(rectangulo4Lado1, rectangulo4Lado2);
            Assert.AreEqual("Error", resultado4);

            //-10*-5= Error
            decimal rectangulo5Lado1 = -10;
            decimal rectangulo5Lado2 = -5;

            string resultado5 = Calculator.Rectangulo(rectangulo5Lado1, rectangulo5Lado2);
            Assert.AreEqual("Error", resultado5);

            //10*6= 60
            decimal rectangulo6Lado1 = 10;
            decimal rectangulo6Lado2 = 6;

            string resultado6 = Calculator.Rectangulo(rectangulo6Lado1, rectangulo6Lado2);
            Assert.AreEqual("60", resultado6);

            //4.5*2=9
            decimal rectangulo7Lado1 = 4.5M;
            decimal rectangulo7Lado2 = 2;

            string resultado7 = Calculator.Rectangulo(rectangulo7Lado1, rectangulo7Lado2);
            Assert.AreEqual("9.0", resultado7);
        }

        [Test]
        [TestCase(TestName = "Área de un triángulo")]
        public void CalcularAreaTriangulo()
        {
            //10*5/2 = 25
            decimal triangulo1Base = 10;
            decimal triangulo1Altura = 5;

            string resultado1 = Calculator.Triangulo(triangulo1Base, triangulo1Altura);
            Assert.AreEqual("25", resultado1);

            //8*5/2 = 20
            decimal triangulo2Base = 8;
            decimal triangulo2Altura = 5;

            string resultado2 = Calculator.Triangulo(triangulo2Base, triangulo2Altura);
            Assert.AreEqual("20", resultado2);

            //2.3*5/2 = 5.75
            decimal triangulo3Base = 2.3M;
            decimal triangulo3Altura = 5;

            string resultado3 = Calculator.Triangulo(triangulo3Base, triangulo3Altura);
            Assert.AreEqual("5.75", resultado3);

            //2.4*0/2 = Error
            decimal triangulo4Base = 2.4M;
            decimal triangulo4Altura = 0;

            string resultado4 = Calculator.Triangulo(triangulo4Base, triangulo4Altura);
            Assert.AreEqual("Error", resultado4);


        }

        [Test]
        [TestCase(TestName = "Área de un pentágono")]
        public void CalcularAreaPentagono()
        {
            decimal pentagono1Perimetro = 25;
            decimal pentagono1Apotema = 3.44M;

            string resultado1 = Calculator.Pentagono(pentagono1Perimetro, pentagono1Apotema);
            Assert.AreEqual("43.00", resultado1);

            //(8*6)/2= Error (el apotema y el perimetro no concuerdan)
            decimal pentagono2Perimetro = 20;
            decimal pentagono2Apotema = 5.51M; //apotema seria 2.75

            string resultado2 = Calculator.Pentagono(pentagono2Perimetro, pentagono2Apotema);
            Assert.AreEqual("Error", resultado2);

            //(30*0)/2= Error
            decimal pentagono3Perimetro = 30;
            decimal pentagono3Apotema = 0;

            string resultado3 = Calculator.Pentagono(pentagono3Perimetro, pentagono3Apotema);
            Assert.AreEqual("Error", resultado3);

            //(-40*-5.51)/2= Error
            decimal pentagono4Perimetro = -40;
            decimal pentagono4Apotema = -5.51M;

            string resultado4 = Calculator.Pentagono(pentagono4Perimetro, pentagono4Apotema);
            Assert.AreEqual("Error", resultado4);


        }

        [Test]
        [TestCase(TestName = "Área de un círculo")]
        public void CalcularAreaCirculo()
        {
            //pi*5^2 = 78.53981633974475
            decimal circulo1Radio = 5;

            string resultado1 = Calculator.Circulo(circulo1Radio);
            Assert.AreEqual("78.54", resultado1);

            //pi*-5^2 = Error
            decimal circulo2Radio = -5;

            string resultado2 = Calculator.Circulo(circulo2Radio);
            Assert.AreEqual("Error", resultado2);

            //pi*0^2 = Error
            decimal circulo3Radio = 0;

            string resultado3 = Calculator.Circulo(circulo3Radio);
            Assert.AreEqual("Error", resultado3);



        }

    }


}
