// Code generated by protoc-gen-go. DO NOT EDIT.
// source: model.proto

package training

import (
	fmt "fmt"
	proto "github.com/golang/protobuf/proto"
	math "math"
)

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion3 // please upgrade the proto package

type MovementType int32

const (
	MovementType_PUSHUPS MovementType = 0
	MovementType_PULLUPS MovementType = 1
)

var MovementType_name = map[int32]string{
	0: "PUSHUPS",
	1: "PULLUPS",
}

var MovementType_value = map[string]int32{
	"PUSHUPS": 0,
	"PULLUPS": 1,
}

func (x MovementType) String() string {
	return proto.EnumName(MovementType_name, int32(x))
}

func (MovementType) EnumDescriptor() ([]byte, []int) {
	return fileDescriptor_4c16552f9fdb66d8, []int{0}
}

type Exercise struct {
	Movement             MovementType `protobuf:"varint,1,opt,name=movement,proto3,enum=training.MovementType" json:"movement,omitempty"`
	Duration             int64        `protobuf:"varint,2,opt,name=duration,proto3" json:"duration,omitempty"`
	XXX_NoUnkeyedLiteral struct{}     `json:"-"`
	XXX_unrecognized     []byte       `json:"-"`
	XXX_sizecache        int32        `json:"-"`
}

func (m *Exercise) Reset()         { *m = Exercise{} }
func (m *Exercise) String() string { return proto.CompactTextString(m) }
func (*Exercise) ProtoMessage()    {}
func (*Exercise) Descriptor() ([]byte, []int) {
	return fileDescriptor_4c16552f9fdb66d8, []int{0}
}

func (m *Exercise) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Exercise.Unmarshal(m, b)
}
func (m *Exercise) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Exercise.Marshal(b, m, deterministic)
}
func (m *Exercise) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Exercise.Merge(m, src)
}
func (m *Exercise) XXX_Size() int {
	return xxx_messageInfo_Exercise.Size(m)
}
func (m *Exercise) XXX_DiscardUnknown() {
	xxx_messageInfo_Exercise.DiscardUnknown(m)
}

var xxx_messageInfo_Exercise proto.InternalMessageInfo

func (m *Exercise) GetMovement() MovementType {
	if m != nil {
		return m.Movement
	}
	return MovementType_PUSHUPS
}

func (m *Exercise) GetDuration() int64 {
	if m != nil {
		return m.Duration
	}
	return 0
}

type Training struct {
	Exercises            []*Exercise `protobuf:"bytes,1,rep,name=exercises,proto3" json:"exercises,omitempty"`
	XXX_NoUnkeyedLiteral struct{}    `json:"-"`
	XXX_unrecognized     []byte      `json:"-"`
	XXX_sizecache        int32       `json:"-"`
}

func (m *Training) Reset()         { *m = Training{} }
func (m *Training) String() string { return proto.CompactTextString(m) }
func (*Training) ProtoMessage()    {}
func (*Training) Descriptor() ([]byte, []int) {
	return fileDescriptor_4c16552f9fdb66d8, []int{1}
}

func (m *Training) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_Training.Unmarshal(m, b)
}
func (m *Training) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_Training.Marshal(b, m, deterministic)
}
func (m *Training) XXX_Merge(src proto.Message) {
	xxx_messageInfo_Training.Merge(m, src)
}
func (m *Training) XXX_Size() int {
	return xxx_messageInfo_Training.Size(m)
}
func (m *Training) XXX_DiscardUnknown() {
	xxx_messageInfo_Training.DiscardUnknown(m)
}

var xxx_messageInfo_Training proto.InternalMessageInfo

func (m *Training) GetExercises() []*Exercise {
	if m != nil {
		return m.Exercises
	}
	return nil
}

func init() {
	proto.RegisterEnum("training.MovementType", MovementType_name, MovementType_value)
	proto.RegisterType((*Exercise)(nil), "training.Exercise")
	proto.RegisterType((*Training)(nil), "training.Training")
}

func init() { proto.RegisterFile("model.proto", fileDescriptor_4c16552f9fdb66d8) }

var fileDescriptor_4c16552f9fdb66d8 = []byte{
	// 184 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xe2, 0xe2, 0xce, 0xcd, 0x4f, 0x49,
	0xcd, 0xd1, 0x2b, 0x28, 0xca, 0x2f, 0xc9, 0x17, 0xe2, 0x28, 0x29, 0x4a, 0xcc, 0xcc, 0xcb, 0xcc,
	0x4b, 0x57, 0x8a, 0xe2, 0xe2, 0x70, 0xad, 0x48, 0x2d, 0x4a, 0xce, 0x2c, 0x4e, 0x15, 0x32, 0xe2,
	0xe2, 0xc8, 0xcd, 0x2f, 0x4b, 0xcd, 0x4d, 0xcd, 0x2b, 0x91, 0x60, 0x54, 0x60, 0xd4, 0xe0, 0x33,
	0x12, 0xd3, 0x83, 0x29, 0xd4, 0xf3, 0x85, 0xca, 0x84, 0x54, 0x16, 0xa4, 0x06, 0xc1, 0xd5, 0x09,
	0x49, 0x71, 0x71, 0xa4, 0x94, 0x16, 0x25, 0x96, 0x64, 0xe6, 0xe7, 0x49, 0x30, 0x29, 0x30, 0x6a,
	0x30, 0x07, 0xc1, 0xf9, 0x4a, 0x36, 0x5c, 0x1c, 0x21, 0x50, 0xed, 0x42, 0x06, 0x5c, 0x9c, 0xa9,
	0x50, 0x7b, 0x8a, 0x25, 0x18, 0x15, 0x98, 0x35, 0xb8, 0x8d, 0x84, 0x10, 0x86, 0xc3, 0x9c, 0x10,
	0x84, 0x50, 0xa4, 0xa5, 0xc1, 0xc5, 0x83, 0x6c, 0xa7, 0x10, 0x37, 0x17, 0x7b, 0x40, 0x68, 0xb0,
	0x47, 0x68, 0x40, 0xb0, 0x00, 0x03, 0x84, 0xe3, 0xe3, 0x03, 0xe2, 0x30, 0x3a, 0x89, 0x46, 0xc1,
	0xfd, 0xb3, 0x8a, 0x09, 0xce, 0x4c, 0x62, 0x03, 0xfb, 0xd5, 0x18, 0x10, 0x00, 0x00, 0xff, 0xff,
	0x26, 0xa8, 0xae, 0x5a, 0xfa, 0x00, 0x00, 0x00,
}
