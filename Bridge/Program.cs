// Em algum lugar no código cliente.
using Bridge;

var tv = new TV();

var remote = new RemoteControl(tv);

remote.TogglePower();

var radio = new Radio();

remote = new AdvancedRemoteControl(radio);

remote.TogglePower();