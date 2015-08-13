Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports GradeLib

Namespace GradeLib.Tests

    <TestClass()> Public Class GradeTests

        <TestMethod()> Public Sub Grade_Constructor_NotNull()
            Dim score As Integer = 0
            Dim target As IGrade = New Grade(score)

            Assert.IsNotNull(target)
        End Sub

        <TestMethod()> Public Sub Grade_ConstructorWrongParameter_ThrowException()
            ' Score < 0
            Dim score As Integer = -1
            Dim target As IGrade = Nothing

            Try
                target = New Grade(score)
            Catch ex As Exception
            End Try

            Assert.IsNull(target)

            ' Score > 100
            score = 101

            Try
                target = New Grade(score)
            Catch ex As Exception
            End Try

            Assert.IsNull(target)
        End Sub

        <TestMethod()> Public Sub Grade_PropertyScore_KeepValue()
            Dim score As Integer = 100
            Dim target As IGrade = New Grade(score)
            Dim expected As Integer = 100
            Dim actual As Integer = target.Score

            Assert.AreEqual(expected, actual)
        End Sub

        <TestMethod()> Public Sub Grade_CalculateScore80_IsGradeA()
            Dim score As Integer = 80
            Dim target As IGrade = New Grade(score)
            Dim expected As String = "A"
            Dim actual As String = target.Calculate()

            Assert.AreEqual(expected, actual)
        End Sub

        <TestMethod()> Public Sub Grade_CalculateScore70_IsGradeB()
            Dim score As Integer = 70
            Dim target As IGrade = New Grade(score)
            Dim expected As String = "B"
            Dim actual As String = target.Calculate()

            Assert.AreEqual(expected, actual)
        End Sub

        <TestMethod()> Public Sub Grade_CalculateScore60_IsGradeC()
            Dim score As Integer = 60
            Dim target As IGrade = New Grade(score)
            Dim expected As String = "C"
            Dim actual As String = target.Calculate()

            Assert.AreEqual(expected, actual)
        End Sub
    End Class


End Namespace
