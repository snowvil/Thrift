namespace java com.thrift.helloworldservice
namespace csharp HelloWorldService

service HelloWorldService{
	string hello (1:string name),
}