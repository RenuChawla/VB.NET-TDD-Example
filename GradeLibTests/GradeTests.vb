Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports GradeLib

Namespace GradeLib.Tests

    <TestClass()> Public Class GradeTests

        <TestMethod()> Public Sub Grade_Constructor_NotNull()
            Dim score As Integer = 0
            Dim target As IGrade = New Grade(score)

            Assert.IsNotNull(target)
        End Sub

        <TestMethod()> Public Sub Grade_CalculateScore80_IsGradeA()
            Dim score As Integer = 80
            Dim target As IGrade = New Grade(score)
            Dim expected As String = "A"
            Dim actual As String = target.Calculate()

            Assert.AreEqual(expected, actual)
        End Sub
    End Class


End Namespace
