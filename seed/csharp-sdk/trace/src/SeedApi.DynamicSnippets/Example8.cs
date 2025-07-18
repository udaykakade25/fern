using global::System.Threading.Tasks;
using SeedTrace;

namespace Usage;

public class Example8
{
    public async global::System.Threading.Tasks.Task Do() {
        var client = new SeedTraceClient(
            token: "<token>",
            clientOptions: new ClientOptions{
                BaseUrl = "https://api.fern.com"
            }
        );

        await client.Admin.StoreTracedWorkspaceV2Async(
            "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            new List<TraceResponseV2>(){
                new TraceResponseV2{
                    SubmissionId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    LineNumber = 1,
                    File = new TracedFile{
                        Filename = "filename",
                        Directory = "directory"
                    },
                    ReturnValue = new DebugVariableValue(

                    ),
                    ExpressionLocation = new ExpressionLocation{
                        Start = 1,
                        Offset = 1
                    },
                    Stack = new StackInformation{
                        NumStackFrames = 1,
                        TopStackFrame = new StackFrame{
                            MethodName = "methodName",
                            LineNumber = 1,
                            Scopes = new List<Scope>(){
                                new Scope{
                                    Variables = new Dictionary<string, DebugVariableValue>(){
                                        ["variables"] = new DebugVariableValue(

                                        ),
                                    }
                                },
                                new Scope{
                                    Variables = new Dictionary<string, DebugVariableValue>(){
                                        ["variables"] = new DebugVariableValue(

                                        ),
                                    }
                                },
                            }
                        }
                    },
                    Stdout = "stdout"
                },
                new TraceResponseV2{
                    SubmissionId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                    LineNumber = 1,
                    File = new TracedFile{
                        Filename = "filename",
                        Directory = "directory"
                    },
                    ReturnValue = new DebugVariableValue(

                    ),
                    ExpressionLocation = new ExpressionLocation{
                        Start = 1,
                        Offset = 1
                    },
                    Stack = new StackInformation{
                        NumStackFrames = 1,
                        TopStackFrame = new StackFrame{
                            MethodName = "methodName",
                            LineNumber = 1,
                            Scopes = new List<Scope>(){
                                new Scope{
                                    Variables = new Dictionary<string, DebugVariableValue>(){
                                        ["variables"] = new DebugVariableValue(

                                        ),
                                    }
                                },
                                new Scope{
                                    Variables = new Dictionary<string, DebugVariableValue>(){
                                        ["variables"] = new DebugVariableValue(

                                        ),
                                    }
                                },
                            }
                        }
                    },
                    Stdout = "stdout"
                },
            }
        );
    }

}
