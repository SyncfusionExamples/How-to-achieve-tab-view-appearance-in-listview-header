# How to achieve tab view appearance in listview's header?

## About the sample

This example will explain how to customize the listview's header item like tabview appearance by using the [HeaderTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~HeaderTemplate.html) property. 

```xml
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
    <ContentPage.BindingContext>
        <local:BookInfoRepository />
    </ContentPage.BindingContext>
     <syncfusion:SfListView x:Name="listView" IsStickyHeader="True" IsStickyFooter="True"
                               HeaderSize="80" FooterSize="60" SelectionBackgroundColor="LightBlue" 
                               ItemSize="90" SelectionMode="Single" ItemTemplate="{StaticResource template}">
        <syncfusion:SfListView.HeaderTemplate>
            <DataTemplate>
                <Grid BackgroundColor="#4CA1FE" HeightRequest="60">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="2" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="2" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="2" />
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="2" />
                    </Grid.ColumnDefinitions>
                    <Grid Grid.Column="1" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                        <Label x:Name="info" BackgroundColor="Transparent" Text="Informations" FontAttributes="Bold" FontSize="18" TextColor="White" 
                              HorizontalTextAlignment="Center" VerticalTextAlignment="Center"  />
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Tapped="InfoTapGestureRecognizerTapped" NumberOfTapsRequired="1"/>
                        </Grid.GestureRecognizers>
                    </Grid>
                    <Grid Grid.Column="3" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                        <Label x:Name="status" BackgroundColor="Transparent" Text="Status" FontAttributes="Bold" FontSize="18" TextColor="White"  
                                HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Tapped="StatusTapGestureRecognizerTapped" NumberOfTapsRequired="1"/>
                        </Grid.GestureRecognizers>
                    </Grid>
                    <Grid Grid.Column="5" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" >
                        <Label x:Name="contacts" BackgroundColor="Transparent" Text="Contacts" FontAttributes="Bold" FontSize="18" TextColor="White" 
                               HorizontalTextAlignment="Center" VerticalTextAlignment="Center"/>
                        <Grid.GestureRecognizers>
                            <TapGestureRecognizer Tapped="ContactsTapGestureRecognizerTapped" NumberOfTapsRequired="1"/>
                        </Grid.GestureRecognizers>
                    </Grid>
                    <BoxView Grid.Column="0" BackgroundColor="White" />
                    <BoxView Grid.Column="2" BackgroundColor="White" />
                    <BoxView Grid.Column="4" BackgroundColor="White" />
                    <BoxView Grid.Column="6" BackgroundColor="White" />
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.HeaderTemplate>
    </syncfusion:SfListView>
</ContentPage>
```
 And define the [GestureRecognizers](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.view.gesturerecognizers?view=xamarin-forms#Xamarin_Forms_View_GestureRecognizers) to each tab view in the header item.

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
