# FontAwesomeMvc
Font Awesome MVC is a HTML extension that wraps the popular Font Awesome project into friendly Razor syntax.


## Installing
If you prefer, there's a nuget package available for this library. [MVC Font Awesome](https://www.nuget.org/packages/ShutterPrism.MVC.FontAwsome/)

Once you download and reference the library you will need to update your web.config file.

```
<add namespace="ShutterPrism.MVC.FontAwesome" />
```

## Using the Library

Once you've updated your web.config file, you can now use fluent syntax to create font awesome icons.

### Examples

The below code, will generate the needed HTML for displaying the retro camera icon in font awesome.

```
@Html.FontAwesome().Icon(FontAwesome.FontAwesomeIcons.CameraRetro)
```

In this example we create a spinning icon. Any font awesome icon can become a spinner, but some are obviously better suited than others.

```
@Html.FontAwesome().Icon(FontAwesome.FontAwesomeIcons.Spinner).Spinner()
```

Everything that font awesome offers is replicated in fluent syntax. So here we will do something a little more complicated. A stacked icon with the top layer spinning. 

```
@Html.FontAwesome().IconStack(
    Html.FontAwesome().Icon(FontAwesome.FontAwesomeIcons.Cog).Inverse().Spinner(),
    Html.FontAwesome().Icon(FontAwesome.FontAwesomeIcons.Square).HtmlAttributes(new { @class = "text-primary" })
).Size(FontAwesome.IconSizes.X2).Angle(FontAwesome.IconAngle.Rotate180)
```



To view all these examples, and a little more detailed documentation visit the projects homepage at [Shutter Prism](https://www.shutterprism.com/Software/FontAwesome).
