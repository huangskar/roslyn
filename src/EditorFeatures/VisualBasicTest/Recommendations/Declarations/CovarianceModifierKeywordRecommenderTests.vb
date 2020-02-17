﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.


Namespace Microsoft.CodeAnalysis.Editor.VisualBasic.UnitTests.Recommendations.Declarations
    Public Class CovarianceModifierKeywordRecommenderTests
        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InAfterOfInInterfaceTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Interface IGoo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutAfterOfInInterfaceTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Interface IGoo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InNotInClassTypeParamTest() As Task
            Await VerifyRecommendationsMissingAsync(<File>Class Goo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutNotInClassTypeParamTest() As Task
            Await VerifyRecommendationsMissingAsync(<File>Class Goo(Of |</File>, "Out")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InNotInStructureTypeParamTest() As Task
            Await VerifyRecommendationsMissingAsync(<File>Structure Goo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutNotInStructureTypeParamTest() As Task
            Await VerifyRecommendationsMissingAsync(<File>Structure Goo(Of |</File>, "Out")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InForSecondInterfaceTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Interface IGoo(Of T, |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutForSecondInterfaceTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Interface IGoo(Of T, |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InNotInMultipleConstraintsTest() As Task
            Await VerifyRecommendationsMissingAsync(<File>Interface IGoo(Of T As {New, |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutNotInMultipleConstraintsTest() As Task
            Await VerifyRecommendationsMissingAsync(<File>Interface IGoo(Of T As {New, |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InAfterOfInDelegateTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Delegate Sub Goo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutAfterOfInDelegateTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Delegate Sub Goo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function InForSecondDelegateTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Delegate Sub Goo(Of |</File>, "In")
        End Function

        <Fact>
        <Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function OutForSecondDelegateTypeParamTest() As Task
            Await VerifyRecommendationsContainAsync(<File>Delegate Sub Goo(Of |</File>, "In")
        End Function

        <WorkItem(530953, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/530953")>
        <Fact, Trait(Traits.Feature, Traits.Features.KeywordRecommending)>
        Public Async Function AfterEolTest() As Task
            Await VerifyRecommendationsContainAsync(
<File>Delegate Sub Goo(Of 
    |</File>, "In")
        End Function
    End Class
End Namespace
