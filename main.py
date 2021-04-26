import kivy
from kivy.app import App
from kivy.uix.label import Label
from kivy.uix.gridlayout import GridLayout
from kivy.uix.textinput import TextInput
from kivy.uix.button import Button

class LoginScreen(GridLayout):

    def __init__(self, **kwargs):
        super(LoginScreen, self).__init__(**kwargs) #super allows to add functionality
        self.cols = 1

        self.inside = GridLayout()
        self.inside.cols = 2 #This function specifies the amount of columns for a element

        self.cols = 2
        self.inside.add_widget(Label(text="UserName: "))
        self.username = TextInput(multiline=False)
        self.inside.add_widget(self.username)

        self.inside.add_widget(Label(text="Password: "))
        self.password = TextInput(multiline=False)
        self.inside.add_widget(self.password)

        self.add_widget(self.inside)

        self.submit = Button(text="Submit", font_size=40)
        self.add_widget(self.submit)


class MyApp(App):
    def build(self):
        self.title = "Qwik Travel LTD"
        return LoginScreen()

if __name__ == "__main__":
    MyApp().run()